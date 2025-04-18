using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class EditTaskPage : ContentPage
{
	public EditTaskPage(EditTaskViewModel editTaskViewModel)
	{
		InitializeComponent();
        BindingContext = editTaskViewModel;
    }
}