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
	[QueryProperty(nameof(Consumption), "Consumption")]
	public partial class EditConsumptionViewModel : BaseViewModel
	{
		LocalDBService _db;

		[ObservableProperty]
		public Consumption _consumption = new();

		[ObservableProperty]
		public double _rating;

		public EditConsumptionViewModel(LocalDBService db)
		{
			_db = db;
		}

		[RelayCommand]
		public async Task SaveButton()
		{
			await _db.UpdateConsumption(Consumption);
			await NavigateBack();
		}

		[RelayCommand]
		public async Task DeleteButton()
		{
			await _db.DeleteConsumption(Consumption);
			await NavigateBack();
			await NavigateBack();
		}
	}
}
