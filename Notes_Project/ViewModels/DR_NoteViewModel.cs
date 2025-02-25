using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Notes_Project.Models;

namespace Notes_Project.ViewModels;

public partial class DR_NoteViewModel: ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private DR_Note _note;
    
    public string _text => _note.Text;
    public DateTime Date => _note.Date;
    public string Identifier => _note.Filename;
    
    public ICommand SaveCommand { get; private set; }
    public ICommand DeleteCommand { get; private set; }
    
    public DR_NoteViewModel(DR_Note note)
    {
        _note = note;
        SaveCommand = new AsyncRelayCommand(Save);
        DeleteCommand = new AsyncRelayCommand(Delete);
    }

    private async Task Save()
    {
        _note.Date = DateTime.Now;
        _note.Save();
        await Shell.Current.GoToAsync($"..?saved={_note.Filename}");
    }

    private async Task Delete()
    {
        _note.Delete();
        await Shell.Current.GoToAsync($"..?deleted={_note.Filename}");
    }
    
    void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("load"))
        {
            _note = DR_Note.Load(query["load"].ToString());
            RefreshProperties();
        }
    }
    
    public void Reload()
    {
        _note = DR_Note.Load(_note.Filename);
        RefreshProperties();
    }

    private void RefreshProperties()
    {
        OnPropertyChanged(nameof(_text));
        OnPropertyChanged(nameof(Date));
    }
}