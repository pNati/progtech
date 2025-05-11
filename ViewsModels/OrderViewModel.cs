public class OrderViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Sandwich> Sandwiches { get; set; }
    public ICommand SubmitOrderCommand { get; set; }
}