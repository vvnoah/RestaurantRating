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
	public partial class AddRestaurantViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		public Restaurant _restaurant = new();

        public AddRestaurantViewModel(LocalDBService db)
        {
            _db = db;
        }

        [RelayCommand]
		public async Task AddRestaurantButton()
		{
			await _db.AddRestaurant(Restaurant);
			await NavigateBack();
		}
	}
}
