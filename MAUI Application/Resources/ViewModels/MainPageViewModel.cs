using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_Application.Resources.Views;

namespace MAUI_Application.Resources.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    IConnectivity connectivity;

    public MainPageViewModel(IConnectivity connectivity)
    {
        this.connectivity = connectivity;
    }

    // Add default constructor

    // [ICommand] is now [RelayCommand] from the .NET community toolkit
    // [CommunityToolkit.Mvvm.Input.RelayCommand]
    [RelayCommand]
    public Task Navigate()
    {
        return Shell.Current.GoToAsync(nameof(FlyoutPageDemo));
    }

    [RelayCommand]
    public async Task CheckInternet()
    {
        NetworkAccess accessType = connectivity.NetworkAccess;

        if (accessType != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("Check internet!", $"Current status: {accessType}", "OK");
        }
    }
}

