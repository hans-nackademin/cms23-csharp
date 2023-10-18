using MauiApp_App.Mvvm.ViewModels;
using MauiApp_App.Mvvm.Views;
using Microsoft.Extensions.Logging;
using Shared.Services;

namespace MauiApp_App
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

            builder.Services.AddSingleton<UserService>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddTransient<AddPage>();
            builder.Services.AddTransient<AddPageViewModel>();
            builder.Services.AddTransient<DetailsPage>();
            builder.Services.AddTransient<DetailsPageViewModel>();
            builder.Services.AddTransient<EditPage>();
            builder.Services.AddTransient<EditPageViewModel>();



            return builder.Build();
        }
    }
}