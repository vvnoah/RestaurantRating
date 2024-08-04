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
	}
}
