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
    [QueryProperty(nameof(Restaurant), "Restaurant")]
    public partial class EditRestaurantViewModel : BaseViewModel
    {
        LocalDBService _db;

        [ObservableProperty]
        Restaurant? _restaurant;

        public EditRestaurantViewModel(LocalDBService db)
        {
            _db = db;
        }

        [RelayCommand]
        public async Task SaveRestaurantButton()
        {
            if (Restaurant == null) return;
            await _db.UpdateRestaurant(Restaurant);
            await NavigateBack();
        }

        [RelayCommand]
        public async Task DeleteRestaurantButton()
        {
			if (Restaurant == null) return;
			await _db.DeleteRestaurant(Restaurant);
            await NavigateBack();
            await NavigateBack();
        }
    }
}
