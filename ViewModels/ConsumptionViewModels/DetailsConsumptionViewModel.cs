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
	[QueryProperty(nameof(ConsumptionId), "ConsumptionId")]
	public partial class DetailsConsumptionViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		int _consumptionId;

		[ObservableProperty]
		Consumption _consumption = new();

		public DetailsConsumptionViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task Load()
		{
			Consumption = await _db.GetConsumptionById(ConsumptionId);
		}
	}
}
