using System.Windows;

namespace WpfBurgerApp.Views
{
    public partial class StartView : Window
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void Kezdjuk_Click(object sender, RoutedEventArgs e)
        {
            VegaOrNot vegaOrNotWindow = new VegaOrNot();
            vegaOrNotWindow.Show();
            this.Close(); 
        }
    }
}
