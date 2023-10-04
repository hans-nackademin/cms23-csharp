using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen.Mvvm.Views
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