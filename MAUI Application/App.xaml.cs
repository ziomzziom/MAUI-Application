namespace MAUI_Application;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();

		MainPage = new NavigationPage(mainPage);
	}
}
