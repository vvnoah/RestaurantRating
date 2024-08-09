using RestaurantRating.ViewModels.VisitViewModels;

namespace RestaurantRating.Views.VisitViews;

public partial class AddVisitView : ContentPage
{
	public AddVisitView(AddVisitViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}