using MAUI_Application.Resources.ViewModels;
using MAUI_Application.Resources.Views;

namespace MAUI_Application;

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

        //services
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

        //viewmodels
        builder.Services.AddTransient<MainPageViewModel>();
        //builder.Services.AddTransient<FlyOutPageDemoViewModel>();

        //pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<FlyoutPageDemo>();


        return builder.Build();
	}
}
