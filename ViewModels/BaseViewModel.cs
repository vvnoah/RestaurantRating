using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RestaurantRating.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [RelayCommand]
        async Task NavigateBack()
        {
            Console.WriteLine(Shell.Current.Navigation.NavigationStack);
            await Shell.Current.Navigation.PopAsync();
        }

		[RelayCommand]
        async Task NavigateCreateRestaurant()
        {
            await Shell.Current.GoToAsync("restaurant/create");
        }
    }
}
