using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace AplicatieProiectMobil
{
    public partial class ReviewPage : ContentPage
    {
        ObservableCollection<string> reviewsList = new ObservableCollection<string>();

        public ReviewPage()
        {
            InitializeComponent();
            ReviewListView.ItemsSource = reviewsList;
        }

        private void OnSendReviewClicked(object sender, EventArgs e)
        {
            // Accesează textul din caseta de text
            string reviewText = ReviewEntry.Text;

            // Adaugă noul review la lista
            reviewsList.Add(reviewText);

            // Actualizează afișarea listei de review-uri
            ReviewListView.ItemsSource = null;
            ReviewListView.ItemsSource = reviewsList;

            // Șterge textul din caseta de text după trimitere
            ReviewEntry.Text = "";
        }

        private void OnDeleteReviewClicked(object sender, EventArgs e)
        {
            // Obține review-ul asociat butonului de ștergere
            var reviewToRemove = (sender as Button)?.CommandParameter as string;

            // Verifică și elimină review-ul din lista
            if (!string.IsNullOrWhiteSpace(reviewToRemove))
            {
                reviewsList.Remove(reviewToRemove);
            }
        }
    }
}

