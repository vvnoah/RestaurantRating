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
			Routing.RegisterRoute("restaurant/index", typeof(IndexRestaurantView));
			Routing.RegisterRoute("restaurant/edit", typeof(EditRestaurantView));
			Routing.RegisterRoute("restaurant/create", typeof(CreateRestaurantView));

			Routing.RegisterRoute("visit/list", typeof(ListVisitsView));
			Routing.RegisterRoute("visit/index", typeof(IndexVisitView));
			Routing.RegisterRoute("visit/edit", typeof(EditVisitView));
		}
	}
}
