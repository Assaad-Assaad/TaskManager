using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class TaskDetailsPage : ContentPage
{
	public TaskDetailsPage(TaskDetailsViewModel taskDetailsViewModel)
	{
		InitializeComponent();
        BindingContext = taskDetailsViewModel;
    }
}