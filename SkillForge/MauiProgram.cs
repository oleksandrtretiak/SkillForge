using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Utilities;
using SkillForge.Core.Pages;
using SkillForge.Core.ViewModels;

namespace SkillForge;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMPowerKitNavigation(mpowerBuilder =>
            {
                mpowerBuilder
                    .ConfigureServices(s =>
                    {
                        s.RegisterNavigations();
                        s.RegisterServices();
                    })
                    .OnAppStart("NavigationPage/MainPage");
            })
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static void RegisterNavigations(this IServiceCollection services)
    {
        services.RegisterForNavigation<MainPage, MainViewModel>();
        services.RegisterForNavigation<SecondPage, SecondViewModel>();
    }

    private static void RegisterServices(this IServiceCollection services)
    {
    }
}