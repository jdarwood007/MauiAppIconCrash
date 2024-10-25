using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiApp6;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterViewModels()
            .RegisterViews()
            ;

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        _ = builder.Services.AddSingleton<AddViewModel>(sp => new AddViewModel());

        return builder;
    }

    private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
    {
        _ = builder.Services.AddTransient<AddPage>();
        _ = builder.Services.AddTransient<MainPage>();

        return builder;
    }
}
