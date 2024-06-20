using Notes_Project.Models;
using Notes_Project.ViewModels;

namespace Notes_Project.Views;

public partial class NotePage : ContentPage
{
    private DR_Note _NoteModel;
    public NotePage()
    {
        InitializeComponent();
        BindingContext = new DR_NoteViewModel(_NoteModel);
    }
}