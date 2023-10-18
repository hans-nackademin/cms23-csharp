using MauiApp_App.Mvvm.ViewModels;

namespace MauiApp_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

    }
}