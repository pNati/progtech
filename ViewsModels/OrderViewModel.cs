using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Services;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Sandwich> Sandwiches { get; } = new();
        public ICommand SubmitOrderCommand { get; }

        public OrderViewModel(OrderService orderService)
        {
            SubmitOrderCommand = new RelayCommand(_ => {/* implement place order */});
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}