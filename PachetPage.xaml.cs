using AplicatieProiectMobil.Models;

namespace AplicatieProiectMobil;

public partial class PachetPage : ContentPage
{
	int count = 0;
	public PachetPage()
	{
		InitializeComponent();
        var pachete = new List<Pachet>
            {
                new Pachet { Eveniment = "Nunta", Locatie="Wonderland", ImageSource = "wonderland.jpg", Pret = "250lei/persoana", Informatii = "Pachetul include meniul, bauturile si CandyBar"},
                new Pachet { Eveniment = "Botez", Locatie="La Cina", ImageSource = "la_cina.jpg",Pret = "150lei/persoana", Informatii = "Pachetul include meniul"}
            };
        var stackLayout = new StackLayout();

		foreach (var Pachet in pachete)
		{
            var image = new Image { Source = Pachet.ImageSource, HeightRequest = 100, WidthRequest = 100 };
            var label = new Label { Text = $"{Pachet.Eveniment}\n{Pachet.Locatie}\n{Pachet.Pret}\n{Pachet.Informatii}" };
			
			var pachetLayout = new StackLayout { Children = {image, label }, Margin = new Thickness(10) };
			stackLayout.Children.Add(pachetLayout);
        }
		Content = stackLayout;
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
            Button.Text = $"Clicked {count} time";
        else
            Button.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(Button.Text);
    }
}
