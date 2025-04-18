using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage(AddTaskViewModel addTaskViewModel)
	{
		InitializeComponent();
        BindingContext = addTaskViewModel;
    }
}