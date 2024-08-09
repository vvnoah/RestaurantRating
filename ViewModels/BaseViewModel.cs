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
            await Shell.Current.Navigation.PopAsync();
        }

        [RelayCommand]
        public static async Task NavigateListRestaurant()
        {
            await Shell.Current.GoToAsync("restaurant/list");
        }

		[RelayCommand]
        public static async Task NavigateAddRestaurant()
        {
            await Shell.Current.GoToAsync("restaurant/add");
        }

        [RelayCommand]
        public static async Task NavigateDetailsRestaurant(int id)
        {
            await Shell.Current.GoToAsync("restaurant/details", true, new Dictionary<string, object>{

				{ "RestaurantId", id}
            });
        }

        [RelayCommand]
        public static async Task NavigateEditRestaurant(Restaurant restaurant)
        {
            if (restaurant == null) return;

			await Shell.Current.GoToAsync("restaurant/edit", true, new Dictionary<string, object>{
				{ "Restaurant", restaurant}
			});
		}

        [RelayCommand]
        public static async Task NavigateAddVisit(int restaurantId)
        {
            await Shell.Current.GoToAsync("restaurant/visit/add", true, new Dictionary<string, object>
            {
                { "RestaurantId", restaurantId }
            });
        }
    }
}
