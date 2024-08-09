using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

		public ObservableCollection<Visit> Visits { get; set; } = new();

		public DetailsRestaurantViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task Load()
		{
			Restaurant = await _db.GetRestaurantById(RestaurantId);

			var visits = await _db.GetAllVisitsForRestaurant(RestaurantId);
			Visits.Clear();
			foreach (var visit in visits)
			{
				Visits.Add(visit);
			}
		}

		[RelayCommand]
		public async Task AddVisitButton()
		{
			await NavigateAddVisit(RestaurantId);
		}
	}
}
