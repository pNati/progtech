using System.Windows;
using WpfBurgerApp.Models; // a rendelési adatok tárolásához
using WpfBurgerApp.Views;  // a következő ablakhoz

namespace WpfBurgerApp.Views
{
    public partial class Drink : Window
    {
        public Drink()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedDrink = "Cola"
            NavigateToDessert();
        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedDrink = "Víz";
            NavigateToDessert();
        }

        private void Beer_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedDrink = "Sör";
            NavigateToDessert();
        }

        private void NavigateToDessert()
        {
            var dessertOrNotWindow = new DessertOrNot();
            dessertOrNotWindow.Show();
            this.Close();
        }
    }
}