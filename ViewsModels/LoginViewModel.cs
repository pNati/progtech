public class LoginViewModel : INotifyPropertyChanged
{
    public string Username { get; set; }
    public string Password { get; set; }
    public ICommand LoginCommand { get; set; }
}