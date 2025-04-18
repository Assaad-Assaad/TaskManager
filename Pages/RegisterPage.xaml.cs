using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel registerViewModel)
	{
		InitializeComponent();
		BindingContext = registerViewModel;
	}
}