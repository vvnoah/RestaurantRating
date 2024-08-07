using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Models;
using RestaurantRating.Views.RestaurantViews;

namespace RestaurantRating.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [RelayCommand]
        public static async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("..");
        }

		[RelayCommand]
        public async Task NavigateAddRestaurant()
        {
            await Shell.Current.GoToAsync("restaurant/list/add");
        }

        [RelayCommand]
        public async Task NavigateDetailsRestaurant(Restaurant restaurant)
        {
            if (restaurant == null) return;

            await Shell.Current.GoToAsync("restaurant/list/details", true, new Dictionary<string, object>{

				{ "Restaurant", restaurant}
            });
        }

        [RelayCommand]
        public async Task NavigateEditRestaurant(Restaurant restaurant)
        {
            if (restaurant == null) return;


			await Shell.Current.GoToAsync("restaurant/list/details/edit", true, new Dictionary<string, object>{
				{ "Restaurant", restaurant}
			});
		}
    }
}
