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

		[Column("restaurant_rating")]
		public double RestaurantRating { get; set;}

		[Column("address")]
		public string Address { get; set; } = "";

		[Column("address_found")]
		public bool AddressFound { get; set; } = false;

		[Column("latitude")]
		public double Latitude { get; set; }

		[Column("longitude")]
		public double Longitude { get; set; }
	}
}
