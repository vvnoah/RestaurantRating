namespace RestaurantRating.Views.RestaurantViews;

using RestaurantRating.ViewModels.RestaurantViewModels;

public partial class ListRestaurantsView : ContentPage
{
	public ListRestaurantsView(ListRestaurantsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}