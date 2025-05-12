using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Models;
using WpfBurgerApp.Services;

namespace WpfBurgerApp.ViewModels
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; } = new();
        public ICommand MarkAsPaidCommand { get; }
        public ICommand CancelOrderCommand { get; }

        public AdminViewModel(OrderService orderService)
        {
            CancelOrderCommand = new RelayCommand(param => orderService.CancelOrder(param as Order));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}