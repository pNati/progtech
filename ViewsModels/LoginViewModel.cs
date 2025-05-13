
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Services;
using WpfBurgerApp.Views;

namespace WpfBurgerApp.ViewsModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel(AuthService auth, Action regView, Action nextView)
        {
            RegisterCommand = new RelayCommand(fn =>
            {
                regView();
            });
            LoginCommand = new RelayCommand(fn => {
                if (Username == null || Password == null) {
                    MessageBox.Show("Minden mező kitöltése kötelező!");
                }
                else
                {
                    var isAuth = auth.Authenticate(Username, Password);
                    if (isAuth)
                    {
                        //Teszt fh: admin. jelszó: admin
                        MessageBox.Show("Sikeres belépés!");
                        nextView();
                    }
                    else
                    {
                        MessageBox.Show("Rossz felhasználónév vagy jelszó!");
                    }
                }
                
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
