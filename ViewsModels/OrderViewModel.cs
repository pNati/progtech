using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Services;
using WpfBurgerApp.Models;
using System.Windows;

namespace WpfBurgerApp.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        //public ObservableCollection<Sandwich> Sandwiches { get; } = new();

        public ICommand SubmitOrderCommand { get; }

        public OrderViewModel(OrderService orderService, Action nextView)
        {
            SubmitOrderCommand = new RelayCommand(_ => {

                var order = new Order
                {
                    IsTakeaway = AppState.isTakeaway,
                    UserId = AppState.User.Id,
                    OrderedAt = DateTime.Now
                };

                try
                {
                    orderService.PlaceOrder(order);
                    MessageBox.Show("Sikeres rendelés.");
                    nextView();
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