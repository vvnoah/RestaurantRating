using Microsoft.Extensions.Logging;
using RestaurantRating.ViewModels.RestaurantViewModels;
using RestaurantRating.Views.RestaurantViews;

namespace RestaurantRating
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

			builder.Services.AddTransient<ListRestaurantsViewModel>();
			builder.Services.AddTransient<ListRestaurantsView>();

			builder.Services.AddTransient<CreateRestaurantViewModel>();
			builder.Services.AddTransient<CreateRestaurantView>();


#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
