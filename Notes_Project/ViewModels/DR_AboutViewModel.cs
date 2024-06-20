using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Notes_Project.ViewModels;

public class DR_AboutViewModel
{
    public string Title => "Materia: ";
    public string Asignatura => "Programacion IV";
    public string TittleName => "Nombre estudiante: ";
    public string Name => "David Rueda";    
    public string TittleProject => "Taller MVVM: ";
    public string Taller => "En casa Progreso 3";
    public string Description => "🇪🇨 Freelancer Illustrator | C# | Concept Artist " +
                                 "📬 Email: angeldavidstudios@outlook.com " +
                                 "📂 My portafolio and Social Networks.";
    public string Instagram => "https://www.instagram.com/angeldavidstudios/";
    public string Version => AppInfo.VersionString;
    public ICommand ShowMoreInfoCommand { get; }

    public DR_AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(Instagram);
}