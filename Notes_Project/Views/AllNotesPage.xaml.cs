using Notes_Project.ViewModels;


namespace Notes_Project.Views;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
        BindingContext = new DR_NotesViewModel();
    }
    
    private void DR_ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        DR_notesCollection.SelectedItem = null;
    }
}