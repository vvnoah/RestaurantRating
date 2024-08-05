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
        public async Task NavigateBack()
        {
            await Shell.Current.Navigation.PopAsync();
        }

		[RelayCommand]
        public async Task NavigateAddRestaurant()
        {
            await Shell.Current.GoToAsync(nameof(AddRestaurantView));
        }

        [RelayCommand]
        public async Task NavigateDetailsRestaurant(Restaurant restaurant)
        {
            if (restaurant == null) return;

            await Shell.Current.GoToAsync(nameof(DetailsRestaurantView), true, new Dictionary<string, object>{
                { "Restaurant", restaurant}
            });
        }
    }
}
