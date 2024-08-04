using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Views.RestaurantViews;

namespace RestaurantRating.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [RelayCommand]
        async Task NavigateBack()
        {
            await Shell.Current.Navigation.PopAsync();
        }

		[RelayCommand]
        async Task NavigateAddRestaurant()
        {
            await Shell.Current.GoToAsync(nameof(AddRestaurantView));
        }
    }
}
