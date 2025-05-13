using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for BurgerSize.xaml
    /// </summary>
    public partial class BurgerSize : Window
    {
        public BurgerSize()
        {
            InitializeComponent();
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedSize = "Kicsi";
            NavigateToDrink();
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedSize = "Közepes";
            NavigateToDrink();
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedSize = "Nagy";
            NavigateToDrink();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Itt betöltjük a főoldalt (StartView) új ablakban
            var startWindow = new StartView();
            startWindow.Show();
            this.Close(); // Bezárjuk a jelenlegi ablakot
        }

        private void NavigateToDrink()
        {
            Drink drinkWindow = new Drink();
            drinkWindow.Show();
            this.Close();
        }
    }
}
