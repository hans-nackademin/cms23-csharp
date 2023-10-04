using Kanelbullen.Mvvm.Views;

namespace Kanelbullen
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();


			Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
			Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
		}
	}
}