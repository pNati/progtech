using System.Windows;

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
            selectedMeat = "Csirke";
            MessageBox.Show($"Kiválasztva: {selectedMeat}");
        }

        private void Beef_Click(object sender, RoutedEventArgs e)
        {
            selectedMeat = "Marha";
            MessageBox.Show($"Kiválasztva: {selectedMeat}");
        }

        private void Pork_Click(object sender, RoutedEventArgs e)
        {
            selectedMeat = "Sertés";
            MessageBox.Show($"Kiválasztva: {selectedMeat}");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {             
            var startWindow = new StartView();
            startWindow.Show();
            this.Close(); 
        }
    }
}
