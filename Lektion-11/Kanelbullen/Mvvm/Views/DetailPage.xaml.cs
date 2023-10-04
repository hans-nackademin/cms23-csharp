using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen.Mvvm.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}