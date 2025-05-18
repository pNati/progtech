using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Views
{
    public partial class Thank : Window
    {
        public Thank()
        {
            Order order = AppState.Order.GetBaseOrder();
            InitializeComponent();
            ordersCountLabel.Content = "Rendelési azonosító: " + order.Id;
        }

        private void New_Click(object sender, EventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
