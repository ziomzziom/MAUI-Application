using MAUI_Application.Resources.Views;

namespace MAUI_Application;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(FlyoutPageDemo), typeof(FlyoutPage));
    }
}
