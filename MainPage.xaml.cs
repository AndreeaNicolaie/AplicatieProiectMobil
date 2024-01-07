using AplicatieProiectMobil.Models;

namespace AplicatieProiectMobil
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var restaurants = new List<Restaurant>
        {
            new Restaurant { Nume = "Wonderland", ImageSource = "wonderland.jpg", Capacitate= "2500 persoane", Locatie = "Feleacu, jud.Cluj" },
            new Restaurant { Nume = "La Cina", ImageSource = "la_cina.jpg", Capacitate= "200 persoane", Locatie = "Str. Dobrogeanu Gherea nr.25, Cluj-Napoca" }
            // Adăugați alte restaurante aici
        };

            // Crearea și configurarea interfeței de utilizator pe baza listei de studenți
            var stackLayout = new StackLayout();

            foreach (var Restaurant in restaurants)
            {
                var image = new Image { Source = Restaurant.ImageSource, HeightRequest = 100, WidthRequest = 100 };
                var label = new Label { Text = $"{Restaurant.Nume}\n{Restaurant.Capacitate}\n{Restaurant.Locatie}" };

                var restaurantLayout = new StackLayout { Children = { image, label }, Margin = new Thickness(10) };
                stackLayout.Children.Add(restaurantLayout);
            }

            Content = stackLayout;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}