using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.RestaurantViewModels
{
	[QueryProperty(nameof(Id), "Id")]
	public partial class DetailsRestaurantViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		int _id;

		[ObservableProperty]
		Restaurant? _restaurant;

		public DetailsRestaurantViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task GetRestaurantById(int id)
		{
			Restaurant = await _db.GetRestaurantById(id);
		}
	}
}
