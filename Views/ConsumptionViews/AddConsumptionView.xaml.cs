using RestaurantRating.ViewModels.ConsumptionViewModels;

namespace RestaurantRating.Views.ConsumptionViews;

public partial class AddConsumptionView : ContentPage
{
	public AddConsumptionView(AddConsumptionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		var slider = (Slider)sender;
		double step = 1;
		double newValue = Math.Round(e.NewValue / step) * step;
		slider.Value = newValue;
	}
}