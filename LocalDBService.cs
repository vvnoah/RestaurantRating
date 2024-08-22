using SQLite;
using RestaurantRating.Models;

namespace RestaurantRating
{
	public class LocalDBService
	{
		private const string DB_NAME = "restaurant_rating_db";
		private readonly SQLiteAsyncConnection _connection;

		public LocalDBService()
		{
			_connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
			_connection.CreateTableAsync<Restaurant>();
			_connection.CreateTableAsync<Consumption>();
		}

		public async Task<List<Restaurant>> GetAllRestaurants()
		{
			return await _connection.Table<Restaurant>().ToListAsync();
		}

		public async Task<Restaurant> GetRestaurantById(int id)
		{
			return await _connection.Table<Restaurant>().Where( x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task AddRestaurant(Restaurant restaurant)
		{
			var restaurant1 = await CheckRestaurantAddress(restaurant);
			await _connection.InsertAsync(restaurant1);
		}

		public async Task UpdateRestaurant(Restaurant restaurant)
		{
			var restaurant1 = await CheckRestaurantAddress(restaurant);
			await _connection.UpdateAsync(restaurant1);
		}

		public async Task DeleteRestaurant(Restaurant restaurant)
		{
			var consumptions = await GetAllConsumptionsForRestaurant(restaurant.Id);

			foreach (var consumption in consumptions)
			{ 
				await DeleteConsumption(consumption);		
			}

			await _connection.DeleteAsync(restaurant);
		}

		public async Task<Restaurant> CheckRestaurantAddress(Restaurant restaurant)
		{
			if(restaurant.Address == "")
			{
				return restaurant;
			}

			var locations = await Geocoding.GetLocationsAsync(restaurant.Address);
			var location = locations?.FirstOrDefault();

			if (location != null)
			{
				restaurant.AddressFound = true;
				restaurant.Latitude = location.Latitude;
				restaurant.Longitude = location.Longitude;
			}
			else
			{
				restaurant.AddressFound = false;
			}

			return restaurant;
		}

		public async Task UpdateRestaurantRating(int id)
		{
			var restaurant = await GetRestaurantById(id);
			var consumptions = await GetAllConsumptionsForRestaurant(id);

			if (consumptions != null && consumptions.Count > 0)
			{
				double average = consumptions.Average(x => x.Rating);
				double rounded = Math.Round(average, 1);

				restaurant.RestaurantRating = rounded;
				await UpdateRestaurant(restaurant);
			}
			else
			{
				restaurant.RestaurantRating = 0;
				await UpdateRestaurant(restaurant);
			}			
		}

		public async Task<List<Consumption>> GetAllConsumptionsForRestaurant(int id)
		{
			return await _connection.Table<Consumption>().Where( x => x.RestaurantId == id).ToListAsync();
		}

		public async Task<Consumption> GetConsumptionById(int id)
		{
			return await _connection.Table<Consumption>().Where( x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task AddConsumption(Consumption consumption)
		{
			await _connection.InsertAsync(consumption);
			await UpdateRestaurantRating(consumption.RestaurantId);
		}

		public async Task UpdateConsumption(Consumption consumption)
		{
			await _connection.UpdateAsync(consumption);
			await UpdateRestaurantRating(consumption.RestaurantId);
		}

		public async Task DeleteConsumption(Consumption consumption)
		{
			await _connection.DeleteAsync(consumption);
			await UpdateRestaurantRating(consumption.RestaurantId);
		}
	}
}
