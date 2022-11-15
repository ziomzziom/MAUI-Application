using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_Application.Resources.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace MAUI_Application.Resources.ViewModels;

public partial class MainPageViewModel : ObservableObject, INotifyPropertyChanged
{
    private readonly IConnectivity _connectivity;
    public ICommand NavigationCommand => new Command(async () => await GoToPage());
    public INavigation Navigation =>
        App.Current.MainPage.Navigation;

    public MainPageViewModel(IConnectivity connectivity)
    {
        _connectivity = connectivity;
    }
    public async Task GoToPage()
    {
        await Navigation.PushAsync<FlyoutPageDemo>();
    }

    [RelayCommand]
    public async Task CheckInternet()
    {
        NetworkAccess networkAccess = _connectivity.NetworkAccess;
        NetworkAccess accessType = networkAccess;

        if (accessType != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Check internet!", $"Current status: {accessType}", "OK");
        }
    }
}



