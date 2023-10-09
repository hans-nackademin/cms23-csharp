using CimoApp.Mvvm.ViewModels;

namespace CimoApp.Mvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}