using System.Windows;
using WpfBurgerApp.WpfBurgerApp;

namespace WpfBurgerApp.Views
{
    public partial class Meal : Window
    {
        // Tárolja a kiválasztott ételt
        private string selectedMeat;

        public Meal()
        {
            InitializeComponent();
        }

        private void Chicken_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedMeat = "Csirke";
            OpenBurgerSizeWindow();
        }

        private void Beef_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedMeat = "Marha";
            OpenBurgerSizeWindow();
        }

        private void Pork_Click(object sender, RoutedEventArgs e)
        {
            AppState.SelectedMeat = "Sertés";
            OpenBurgerSizeWindow();
        }


        private void OpenBurgerSizeWindow()
        {
            BurgerSize burgerSizeWindow = new BurgerSize();
            burgerSizeWindow.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {             
            var startWindow = new StartView();
            startWindow.Show();
            this.Close(); 
        }
    }
}
