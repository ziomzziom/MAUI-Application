using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;


namespace MAUI_Application.Resources.ViewModels 
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
        }


        // [CommunityToolkit.Mvvm.Input.ICommand]
        [RelayCommand]
        private void Navigate => Shell.Current.GoToAsync(nameof(Navigate)).GetAwaiter();
    }
}

