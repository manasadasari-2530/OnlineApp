using Syncfusion.Maui.Core.Hosting;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace OnlineApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
           // AddElectronicServices(builder.Services);
            return builder.Build();
        }
        //private static IServiceCollection AddElectronicServices(IServiceCollection services)
        //{
        //  services.AddSingleton<ElectronicServices>();
        //   services.AddSingleton<HomePage>()
        //         .TryAddSingleton<HomePageViewModel>();
        //    services.AddSingletonWithShellRoute<HomePage,
        //        HomePageViewModel>(nameof(HomePage));
        //    services.AddTransientWithShellRoute<AllPizzasPage, AllPizzaViewModel>(nameof(AllPizzasPage));
        //    services.AddTransientWithShellRoute<DetailPage, DetailsViewModel>(nameof(DetailPage));

        //    services.AddSingleton<CartViewModel>();
        //   services.AddTransient<CartPage>();
        //   return services;
        //}
    }
    }

