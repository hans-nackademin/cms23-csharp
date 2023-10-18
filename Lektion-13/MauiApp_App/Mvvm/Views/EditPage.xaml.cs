using MauiApp_App.Mvvm.ViewModels;

namespace MauiApp_App.Mvvm.Views;

public partial class EditPage : ContentPage
{
    public EditPage(EditPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}