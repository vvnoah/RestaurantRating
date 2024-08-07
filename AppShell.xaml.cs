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
			//Routing.RegisterRoute(nameof(ListRestaurantsView), typeof(ListRestaurantsView));
			//Routing.RegisterRoute(nameof(EditRestaurantView), typeof(EditRestaurantView));
			//Routing.RegisterRoute(nameof(AddRestaurantView), typeof(AddRestaurantView));
			//Routing.RegisterRoute(nameof(DetailsRestaurantView), typeof(DetailsRestaurantView));
			//Routing.RegisterRoute(nameof(EditRestaurantView), typeof(EditRestaurantView));

			Routing.RegisterRoute("restaurant/list", typeof(ListRestaurantsView));
			Routing.RegisterRoute("restaurant/list/add", typeof(AddRestaurantView));
			Routing.RegisterRoute("restaurant/list/details", typeof(DetailsRestaurantView));
			Routing.RegisterRoute("restaurant/list/details/edit", typeof(EditRestaurantView));



		}
	}
}
