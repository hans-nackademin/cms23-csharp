using MauiApp_App.Mvvm.ViewModels;

namespace MauiApp_App.Mvvm.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}