using System.Windows;
using System.Windows.Controls;

namespace WpfBurgerApp.Views
{
    public partial class VegaOrNot : Window
    {
        public VegaOrNot()
        {
            InitializeComponent();
        }

        private void Vega_Click(object sender, RoutedEventArgs e)
        {
            Vega vegaWindow = new Vega(); // új ablak példányosítása
            vegaWindow.Show();           // megnyitása
            this.Close();                // jelenlegi ablak bezárása (opcionális)
        }

        private void Husos_Click(object sender, RoutedEventArgs e)
        {
            Meal mealWindow = new Meal(); // új ablak példányosítása
            mealWindow.Show();           // megnyitása
            this.Close();                // jelenlegi ablak bezárása (opcionális)
        }
    }
}
