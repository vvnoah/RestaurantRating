using CommunityToolkit.Mvvm.ComponentModel;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.RestaurantViewModels
{
	[QueryProperty(nameof(Restaurant), "Restaurant")]
	public partial class DetailsRestaurantViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		Restaurant? _restaurant;

		public DetailsRestaurantViewModel(LocalDBService db)
		{
			_db = db;
		}
	}
}
