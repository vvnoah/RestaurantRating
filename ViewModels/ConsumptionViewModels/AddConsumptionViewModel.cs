using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.ConsumptionViewModels
{
	[QueryProperty(nameof(RestaurantId), "RestaurantId")]
	public partial class AddConsumptionViewModel : BaseViewModel
    {
		LocalDBService _db;

		[ObservableProperty]
		int _restaurantId;

		[ObservableProperty]
		public Consumption _consumption = new();

		[ObservableProperty]
		public double _rating;

		public AddConsumptionViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task SaveConsumptionButton()
		{
			Consumption.RestaurantId = RestaurantId;
			Consumption.Date = DateTime.Now;
			Consumption.Rating = Rating;
			await _db.AddConsumption(Consumption);
			await NavigateBack();
		}
	}
}
