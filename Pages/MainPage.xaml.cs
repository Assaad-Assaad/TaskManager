using TaskManager.ViewModels;

namespace TaskManager.Pages
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

       
    }

}
