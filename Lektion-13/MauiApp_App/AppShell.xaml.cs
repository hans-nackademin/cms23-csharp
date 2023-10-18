using MauiApp_App.Mvvm.Views;

namespace MauiApp_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
            Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
        }
    }
}