
using System.ComponentModel;
using System.Windows;
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
            LoginCommand = new RelayCommand(fn => {
                var isAuth = auth.Authenticate(Username, Password);
                if (isAuth)
                {
                    //Teszt fh: admin. jelszó: admin
                    MessageBox.Show("Sikeres belépés!");
                }
                else {
                    MessageBox.Show("Rossz felhasználónév vagy jelszó!");
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
