using Notes_Project.Models;
using Notes_Project.ViewModels;

namespace Notes_Project.Views;

public partial class NotePage : ContentPage
{
    private Note _NoteModel;
    public NotePage()
    {
        InitializeComponent();
        BindingContext = new NoteViewModel(_NoteModel);
    }
}