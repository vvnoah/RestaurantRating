using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.RestaurantViewModels
{
	[QueryProperty(nameof(RestaurantId), "RestaurantId")]
	public partial class DetailsRestaurantViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		int _restaurantId;

		[ObservableProperty]
		Restaurant _restaurant = new();

		public ObservableCollection<Consumption> Consumptions { get; set; } = new();

		public DetailsRestaurantViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task Load()
		{
			Restaurant = await _db.GetRestaurantById(RestaurantId);

			var consumptions = await _db.GetAllConsumptionsForRestaurant(RestaurantId);
			Consumptions.Clear();
			foreach (var consumption in consumptions)
			{
				Consumptions.Add(consumption);
			}			
		}

		[RelayCommand]
		public async Task AddConsumptionButton()
		{
			await NavigateAddConsumption(RestaurantId);
		}
	}
}
