using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty, NotifyPropertyChangedFor(nameof(Initial))]
        private string _name = "Asaad Asaad";

        [ObservableProperty]
        private string _email = "asaad@example.com";

        public string Initial => Name[0].ToString().ToUpper();

        [RelayCommand]
        private async Task LogoutAsync()
        {
            // Confirm logout
            bool confirm = await Application.Current.MainPage.DisplayAlert("Logout", "Are you sure you want to logout?", "Yes", "No");
            if (confirm)
            {
                // Clear session data (e.g., remove authentication tokens)
                Preferences.Set("IsLoggedIn", false);

                // Navigate to the Login Page
                await Shell.Current.GoToAsync("//LoginPage"); // Replace with your login route
            }
        }
    }
}
