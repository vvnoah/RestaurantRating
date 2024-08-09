using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.VisitViewModels
{
	[QueryProperty(nameof(RestaurantId), "RestaurantId")]
	public partial class AddVisitViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		int _restaurantId;

		[ObservableProperty]
		public Visit _visit = new();

		public AddVisitViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task SaveVisitButton()
		{
			Visit.RestaurantId = RestaurantId;
			Visit.Date = DateTime.Now;
			await _db.AddVisit(Visit);
			await NavigateBack();
		}
	}
}
