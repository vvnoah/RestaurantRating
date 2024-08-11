using RestaurantRating.ViewModels.ConsumptionViewModels;

namespace RestaurantRating.Views.ConsumptionViews;

public partial class AddConsumptionView : ContentPage
{
	public AddConsumptionView(AddConsumptionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}