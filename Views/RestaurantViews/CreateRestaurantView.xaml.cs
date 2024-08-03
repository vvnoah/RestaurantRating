using RestaurantRating.ViewModels.RestaurantViewModels;

namespace RestaurantRating.Views.RestaurantViews;

public partial class CreateRestaurantView : ContentPage
{
	public CreateRestaurantView(CreateRestaurantViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}