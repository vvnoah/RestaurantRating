using Microsoft.Extensions.Logging;
using RestaurantRating.ViewModels.RestaurantViewModels;
using RestaurantRating.Views.RestaurantViews;
using CommunityToolkit.Maui;

namespace RestaurantRating
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
				.UseMauiCommunityToolkit()
				.ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            builder.Services.AddSingleton<LocalDBService>();
            builder.Services.AddTransient<ListRestaurantsViewModel>();
            builder.Services.AddTransient<ListRestaurantsView>();
            builder.Services.AddTransient<AddRestaurantViewModel>();
            builder.Services.AddTransient<AddRestaurantView>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}