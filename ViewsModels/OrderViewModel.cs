using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Services;
using WpfBurgerApp.Models;
using System.Windows;
using WpfBurgerApp.Decorator;

namespace WpfBurgerApp.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        //public ObservableCollection<Sandwich> Sandwiches { get; } = new();

        public ICommand SubmitOrderCommand { get; }

        public OrderViewModel(OrderService orderService, Action nextView)
        {
            SubmitOrderCommand = new RelayCommand(_ => {
                try
                {
                    Order order = AppState.Order.GetBaseOrder();
                    Order? ujOrder = orderService.PlaceOrder(order);

                    if (ujOrder != null)
                    {
                        MessageBox.Show("Sikeres rendelés: ");
                        AppState.Order = ujOrder;
                        //AppState.nextOrderId = ujOrder.Id;
                        nextView();
                    }
                    else {
                        MessageBox.Show("Sikertelen rendelés.");
                    }
                   
                }
                catch (Exception e) {
                    MessageBox.Show("Sikertelen rendelés.");
                    MessageBox.Show(e.Message);
                }
               
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}