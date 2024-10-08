﻿using System;
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
        public static async Task NavigateAddConsumption(int restaurantId)
        {
            await Shell.Current.GoToAsync("restaurant/consumption/add", true, new Dictionary<string, object>
            {
                { "RestaurantId", restaurantId }
            });
        }

        [RelayCommand]
        public static async Task NavigateDetailsConsumption(int consumptionId)
        {
            await Shell.Current.GoToAsync("restaurant/consumption/details", true, new Dictionary<string, object>
            {
                { "ConsumptionId", consumptionId }
            });
        }

        [RelayCommand]
        public static async Task NavigateEditConsumption(Consumption consumption)
        {
            await Shell.Current.GoToAsync("restaurant/consumption/edit", true, new Dictionary<string, object>
            {
                { "Consumption", consumption }
            });
        }

        [RelayCommand]
		public static async Task OpenMapAsync(Restaurant restaurant)
		{
			// Construct the URI based on the platform
			string uri;

			if (DeviceInfo.Platform == DevicePlatform.iOS)
			{
				// Use Apple Maps URL scheme for iOS
				uri = $"http://maps.apple.com/?ll={restaurant.Latitude},{restaurant.Longitude}";
			}
			else
			{
				// Use Google Maps URL scheme for Android
				uri = $"geo:{restaurant.Latitude},{restaurant.Longitude}?q={restaurant.Latitude},{restaurant.Longitude}";
			}

			// Create a URI object
			var mapUri = new Uri(uri);

			// Open the URI using the Launcher
			await Launcher.OpenAsync(mapUri);
		}
	}
}
