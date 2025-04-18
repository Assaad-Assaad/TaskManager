using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskManager.Models;
using TaskManager.Pages;

namespace TaskManager.ViewModels
{
    public partial class AllTasksViewModel : ObservableObject
    {
        public ObservableCollection<TaskModel> Tasks { get; set; } = [];


        [RelayCommand]
        private void AddTask()
        {

            Tasks.Add(new TaskModel
            {
                Id = 1,
                Title = "Finish Report",
                DueDate = DateTime.Now.AddDays(1),
                Priority = "High"
            });
            Tasks.Add(new TaskModel
            {
                Id = 2,
                Title = "Team Meeting",
                DueDate = DateTime.Now.AddDays(3),
                Priority = "Medium"
            });
            Tasks.Add(new TaskModel
            {
                Id = 3,
                Title = "Grocery Shopping",
                DueDate = DateTime.Now.AddDays(5),
                Priority = "Low"
            });
            Tasks.Add(new TaskModel
            {
                Id = 4,
                Title = "Client Call",
                DueDate = DateTime.Now.AddDays(2),
                Priority = "High"
            });

        }

        [RelayCommand]
        private async Task GoToTaskDetailsPageAsync(TaskModel task)
        {
            if (task == null) return;

            await Shell.Current.GoToAsync(nameof(TaskDetailsPage), true, new Dictionary<string, object>
            {
                {"TaskModel", task}
            });
        }


    }
}
