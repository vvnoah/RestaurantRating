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
			_connection.CreateTableAsync<Visit>();
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
			await _connection.DeleteAsync(restaurant);
		}

		public async Task<List<Visit>> GetAllVisitsForRestaurant(int id)
		{
			return await _connection.Table<Visit>().Where( x => x.RestaurantId == id).ToListAsync();
		}

		public async Task<Visit> GetVisitById(int id)
		{
			return await _connection.Table<Visit>().Where( x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task AddVisit(Visit visit)
		{
			await _connection.InsertAsync(visit);
		}

		public async Task UpdateVisit(Visit visit)
		{
			await _connection.UpdateAsync(visit);
		}

		public async Task DeleteVisit(Visit visit)
		{
			await _connection.DeleteAsync(visit);
		}
	}
}
