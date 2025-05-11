public class AdminViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Order> Orders { get; set; }
    public ICommand MarkAsPaidCommand { get; set; }
    public ICommand CancelOrderCommand { get; set; }

}