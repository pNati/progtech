using System.Windows;
using WpfBurgerApp.Data;
using WpfBurgerApp.Data_management;
using WpfBurgerApp.Models;
using WpfBurgerApp.Services;

namespace WpfBurgerApp.Views
{
    public partial class StartView : Window
    {
        public StartView()
        {
            var dbContext = new AppDbContext();
            var orderRepo = new OrderRepository(dbContext);
            var oService = new OrderService(orderRepo);

            InitializeComponent();
            ordersCountLabel.Content = "Rendelések száma: " + oService.GetAllOrder().Count();
        }

        private void Kezdjuk_Click(object sender, RoutedEventArgs e)
        {
            VegaOrNot vegaOrNotWindow = new VegaOrNot();
            vegaOrNotWindow.Show();
            this.Close(); 
        }
    }
}
