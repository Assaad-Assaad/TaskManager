using TaskManager.ViewModels;

namespace TaskManager.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel settingsViewModel)
	{
		InitializeComponent();
        BindingContext = settingsViewModel;
    }
}