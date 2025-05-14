using System.Windows;

namespace WpfBurgerApp.Views
{
    public partial class DessertOrNot : Window
    {
        public DessertOrNot()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            var dessertWindow = new Dessert();
            dessertWindow.Show();
            AppState.Dessert = true;
            this.Close();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            AppState.Dessert = false;
            this.Close();
        }
    }
}
