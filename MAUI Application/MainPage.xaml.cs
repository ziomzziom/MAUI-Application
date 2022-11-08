using MAUI_Application.Resources.ViewModels;

namespace MAUI_Application;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
    }

    public MainPageViewModel ViewModel()
    {
        return (MainPageViewModel)BindingContext;
    }
}

