using CommunityToolkit.Mvvm.ComponentModel;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.RestaurantViewModels
{
	public partial class DetailsRestaurantViewModel : BaseViewModel
	{
		[ObservableProperty]
		Restaurant _restaurant = new() { Id = 69, RestaurantName = "Mc Downalds"};
	}
}
