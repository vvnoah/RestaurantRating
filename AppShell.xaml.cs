using RestaurantRating.Views.ConsumptionViews;
using RestaurantRating.Views.RestaurantViews;

namespace RestaurantRating
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			RegisterRoutes();
		}

		private void RegisterRoutes()
		{
			Routing.RegisterRoute("restaurant/list", typeof(ListRestaurantsView));
			Routing.RegisterRoute("restaurant/add", typeof(AddRestaurantView));
			Routing.RegisterRoute("restaurant/details", typeof(DetailsRestaurantView));
			Routing.RegisterRoute("restaurant/edit", typeof(EditRestaurantView));

			Routing.RegisterRoute("restaurant/consumption/add", typeof(AddConsumptionView));
			Routing.RegisterRoute("restaurant/consumption/details", typeof(DetailsConsumptionView));
			Routing.RegisterRoute("restaurant/consumption/edit", typeof(EditConsumptionView));
		}
	}
}
