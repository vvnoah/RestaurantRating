using SQLite;

namespace RestaurantRating.Models
{
	[Table("restaurant")]
	public class Restaurant
	{
		[Column("id")]
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[Column("restaurant_name")]
		public string RestaurantName { get; set; } = "";

		[Column("restaurant_address")]
		public string RestaurantAddress { get; set; } = "";
	}
}
