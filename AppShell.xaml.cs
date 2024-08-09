using RestaurantRating.Views.RestaurantViews;
using RestaurantRating.Views.VisitViews;

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

			Routing.RegisterRoute("restaurant/visit/add", typeof(AddVisitView));
		}
	}
}
