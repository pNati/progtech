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
            Vega vegaWindow = new Vega(); // �j ablak p�ld�nyos�t�sa
            vegaWindow.Show();           // megnyit�sa
            this.Close();                // jelenlegi ablak bez�r�sa (opcion�lis)
        }

        private void Husos_Click(object sender, RoutedEventArgs e)
        {
            Meal mealWindow = new Meal(); // �j ablak p�ld�nyos�t�sa
            mealWindow.Show();           // megnyit�sa
            this.Close();                // jelenlegi ablak bez�r�sa (opcion�lis)
        }
    }
}
