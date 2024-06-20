namespace Notes_Project.Views;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            DR_CounterBtn.Text = $"Clicked {count} time";
        else
            DR_CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(DR_CounterBtn.Text);
    }
}