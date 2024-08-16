using RestaurantRating.ViewModels.ConsumptionViewModels;

namespace RestaurantRating.Views.ConsumptionViews;

public partial class DetailsConsumptionView : ContentPage
{
	public DetailsConsumptionView(DetailsConsumptionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}