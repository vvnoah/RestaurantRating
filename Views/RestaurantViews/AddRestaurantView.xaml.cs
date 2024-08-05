using CommunityToolkit.Mvvm.ComponentModel;
using RestaurantRating.Models;
using RestaurantRating.ViewModels.RestaurantViewModels;

namespace RestaurantRating.Views.RestaurantViews;

public partial class AddRestaurantView : ContentPage
{
	public AddRestaurantView(AddRestaurantViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}