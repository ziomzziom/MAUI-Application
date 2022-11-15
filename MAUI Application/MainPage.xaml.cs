using AndroidX.Lifecycle;
using MAUI_Application.Resources.ViewModels;

namespace MAUI_Application;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewmodel)
    {
        InitializeComponent();

        BindingContext = viewmodel;
    }
}

