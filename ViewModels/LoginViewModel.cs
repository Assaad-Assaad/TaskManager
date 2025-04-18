using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using TaskManager.Pages;

namespace TaskManager.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;



        [RelayCommand]
        private async Task NavigateToRegisterAsync() =>
            await Shell.Current.GoToAsync(nameof(RegisterPage));


        [RelayCommand]
        private async Task LoginAsync()
        {
            // Login validation
            // Call API
            // Redirect to the main page 

            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        
    }
}
