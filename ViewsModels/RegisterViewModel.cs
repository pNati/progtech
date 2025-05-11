public class RegisterViewModel : INotifyPropertyChanged
{
    public string Username { get; set; }
    public string Password { get; set; }
    public ICommand RegisterCommand { get; set; }
}