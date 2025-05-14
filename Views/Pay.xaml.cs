using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBurgerApp.Views
{
    public partial class Pay : Window
    {
        private void Cash_Click(object sender, RoutedEventArgs e)
        { 
            Thank thankWindow = new Thank();
            thankWindow.Show();
            this.Close();
        }

        private void Creditcard_Click(object sender, RoutedEventArgs e)
        {
            Thank thankWindow = new Thank();
            thankWindow.Show();
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
