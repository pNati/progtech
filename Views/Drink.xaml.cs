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
using WpfBurgerApp.Models; // a rendelési adatok tárolásához
using WpfBurgerApp.Views;  // a következő ablakhoz

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for Drink.xaml
    /// </summary>
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
            AppState.SelectedDrink = "Cola";
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

        private void Limonad_Click(object sender, RoutedEventArgs e) {
            AppState.SelectedDrink = "Limonádé";
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