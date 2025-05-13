using System;
using System.Windows;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for Vega.xaml
    /// </summary>
    public partial class Vega : Window
    {
        public Vega()
        {
            InitializeComponent();
        }

        // Vissza gomb eseménykezelője
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Itt betöltjük a főoldalt (StartView) új ablakban
            var startWindow = new StartView();
            startWindow.Show();
            this.Close(); // Bezárjuk a jelenlegi ablakot
        }

        // Vega burger gomb eseménykezelője
        private void VegaBurger_Click(object sender, RoutedEventArgs e)
        {
            // Itt betöltjük az OrderView ablakot
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            this.Close(); // Bezárjuk a Vega ablakot
        }
    }
}
