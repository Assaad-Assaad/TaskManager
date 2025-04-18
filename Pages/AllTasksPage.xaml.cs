using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class AllTasksPage : ContentPage
{
	public AllTasksPage(AllTasksViewModel allTasksViewModel)
	{
		InitializeComponent();
        BindingContext = allTasksViewModel;
    }
}