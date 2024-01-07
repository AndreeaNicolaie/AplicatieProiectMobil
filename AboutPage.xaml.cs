namespace AplicatieProiectMobil;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private void OnLinkLabelTapped(object sender, EventArgs e)
    {
        var uri = new Uri("https://www.instagram.com/agencyevents20023/"); 
        Launcher.OpenAsync(uri);
    }
}