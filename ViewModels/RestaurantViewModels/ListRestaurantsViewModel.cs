using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RestaurantRating.Models;
using CommunityToolkit.Mvvm.Input;

namespace RestaurantRating.ViewModels.RestaurantViewModels
{
    public partial class ListRestaurantsViewModel : BaseViewModel
    {
        public ObservableCollection<Restaurant> Restaurants { get; set; } = new();

        LocalDBService _db;

        public ListRestaurantsViewModel(LocalDBService db)
        {
            _db = db;
        }

        [RelayCommand]
        public async Task GetRestaurants()
        {
			var restaurants = await _db.GetAllRestaurants();
			Restaurants.Clear();
			foreach (var restaurant in restaurants)
			{
				Restaurants.Add(restaurant);
			}
		}
    }
}
