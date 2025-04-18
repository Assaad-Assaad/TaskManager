using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Pages;

namespace TaskManager.ViewModels
{
    public partial class TaskDetailsViewModel : ObservableObject
    {




        //[RelayCommand]
        //private async Task GoToEditPageAsync(TaskModel task)
        //{
        //    if (task == null) return;

        //    //var editPage = new EditTaskPage(task);
        //    await Shell.Current.GoToAsync(nameof(EditTaskPage), true, new Dictionary<string, object>
        //    {
        //        {"TaskModel", task }
        //    });

        //    //var editPage = new EditTaskPage(task);
        //    //await Shell.Current.GoToAsync($"//{nameof(EditTaskPage)}", true, new Dictionary<string, object>
        //    //{
        //    //    { nameof(EditTaskPage.Task), task }
        //    //});

        //}




        [RelayCommand]
        private async Task GoToEditPageAsync() =>
            await Shell.Current.GoToAsync(nameof(EditTaskPage));



    }
}
