using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen.Mvvm.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}