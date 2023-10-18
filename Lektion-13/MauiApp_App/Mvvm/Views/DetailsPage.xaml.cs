using MauiApp_App.Mvvm.ViewModels;

namespace MauiApp_App.Mvvm.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

}