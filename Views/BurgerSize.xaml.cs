using System.Windows;
using WpfBurgerApp.Views;

namespace WpfBurgerApp.Views
{
    public partial class BurgerSize : Window
    {
        public BurgerSize() => InitializeComponent();

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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
