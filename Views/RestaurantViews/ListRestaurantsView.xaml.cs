namespace RestaurantRating.Views.RestaurantViews;

using RestaurantRating.ViewModels.RestaurantViewModels;
using CommunityToolkit.Mvvm.Input;

public partial class ListRestaurantsView : ContentPage
{
	public ListRestaurantsView(ListRestaurantsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}