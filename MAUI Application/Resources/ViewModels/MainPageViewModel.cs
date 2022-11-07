using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_Application.Resources.Views;

namespace MAUI_Application.ViewModels
{

    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;

        public MainViewModel(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
        }


        // [ICommand] is now [RelayCommand] from the .NET community toolkit
        // [CommunityToolkit.Mvvm.Input.RelayCommand]
        [RelayCommand]
        Task Navigate() =>
            Shell.Current.GoToAsync(nameof(FlyoutPageDemo));


        [RelayCommand]
        async Task CheckInternet()
        {
            NetworkAccess accessType = connectivity.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Check internet!", $"Current status: {accessType}", "OK");
            }
        }
    }
}

