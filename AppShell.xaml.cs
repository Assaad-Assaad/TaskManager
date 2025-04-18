using TaskManager.Pages;

namespace TaskManager
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(TaskDetailsPage), typeof (TaskDetailsPage));
            Routing.RegisterRoute(nameof(EditTaskPage), typeof(EditTaskPage));
        }
    }
}
