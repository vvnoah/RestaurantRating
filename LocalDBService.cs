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
			await _connection.InsertAsync(restaurant);
		}

		public async Task UpdateRestaurant(Restaurant restaurant)
		{
			await _connection.UpdateAsync(restaurant);
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
		}

		public async Task UpdateConsumption(Consumption consumption)
		{
			await _connection.UpdateAsync(consumption);
		}

		public async Task DeleteConsumption(Consumption consumption)
		{
			await _connection.DeleteAsync(consumption);
		}
	}
}
