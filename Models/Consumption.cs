﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Models
{
	[Table("consumption")]
	public class Consumption
	{
		[Column("id")]
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[Column("restaurant_id")]
		public int RestaurantId { get; set; }

		[Column("date")]
		public DateTime Date { get; set; }

		[Column("title")]
		public string Title { get; set; } = "";

		[Column("description")]
		public string Description { get; set; } = "";

		[Column("rating")]
		public double Rating { get; set; }
	}
}
