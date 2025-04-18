using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;



        [RelayCommand]
        private async Task NavigateToLoginAsync() =>
            await Shell.Current.GoToAsync("..");
    }
}
