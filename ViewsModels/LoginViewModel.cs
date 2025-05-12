
using System.ComponentModel;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Services;

namespace WpfBurgerApp.ViewsModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; }

        public LoginViewModel(AuthService auth)
        {
            LoginCommand = new RelayCommand(_ => auth.Authenticate(Username, Password));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
