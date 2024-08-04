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
			Routing.RegisterRoute(nameof(ListRestaurantsView), typeof(ListRestaurantsView));
			Routing.RegisterRoute(nameof(IndexRestaurantView), typeof(IndexRestaurantView));
			Routing.RegisterRoute(nameof(EditRestaurantView), typeof(EditRestaurantView));
			Routing.RegisterRoute(nameof(AddRestaurantView), typeof(AddRestaurantView));

			Routing.RegisterRoute(nameof(ListVisitsView), typeof(ListVisitsView));
			Routing.RegisterRoute(nameof(IndexVisitView), typeof(IndexVisitView));
			Routing.RegisterRoute(nameof(EditVisitView), typeof(EditVisitView));
		}
	}
}
