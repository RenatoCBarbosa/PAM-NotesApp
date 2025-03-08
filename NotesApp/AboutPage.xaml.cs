namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void PerfilButton_Clicked(object sender, EventArgs e)
    {
		Uri link = new Uri("https://github.com/RenatoCBarbosa"); //Para criar um link para levar até meu GitHub
		Launcher.OpenAsync(link);
    }
}