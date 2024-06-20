using Notes_Project.ViewModels;

namespace Notes_Project.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        BindingContext = new DR_AboutViewModel();
    }
}