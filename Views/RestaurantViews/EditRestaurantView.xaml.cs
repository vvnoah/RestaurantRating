using RestaurantRating.ViewModels.RestaurantViewModels;

namespace RestaurantRating.Views.RestaurantViews;

public partial class EditRestaurantView : ContentPage
{
	public EditRestaurantView(EditRestaurantViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}