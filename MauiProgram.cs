using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

using RestaurantRating.Views.RestaurantViews;
using RestaurantRating.Views.ConsumptionViews;

using RestaurantRating.ViewModels.RestaurantViewModels;
using RestaurantRating.ViewModels.ConsumptionViewModels;

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

            builder.Services.AddTransient<DetailsRestaurantViewModel>();
            builder.Services.AddTransient<DetailsRestaurantView>();

            builder.Services.AddTransient<EditRestaurantViewModel>();
            builder.Services.AddTransient<EditRestaurantView>();

            builder.Services.AddTransient<AddConsumptionViewModel>();
            builder.Services.AddTransient<AddConsumptionView>();

            builder.Services.AddTransient<DetailsConsumptionViewModel>();
            builder.Services.AddTransient<DetailsConsumptionView>();

            builder.Services.AddTransient<EditConsumptionViewModel>();
            builder.Services.AddTransient<EditConsumptionView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}