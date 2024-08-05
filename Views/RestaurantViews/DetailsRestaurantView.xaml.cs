using RestaurantRating.ViewModels.RestaurantViewModels;

namespace RestaurantRating.Views.RestaurantViews;

public partial class DetailsRestaurantView : ContentPage
{
	public DetailsRestaurantView(DetailsRestaurantViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}