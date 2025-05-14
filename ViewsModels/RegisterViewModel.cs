using System.ComponentModel;
using System.Windows.Input;
using WpfBurgerApp.Data;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Models;
using WpfBurgerApp.Data_management;
using System.Windows;

namespace WpfBurgerApp.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }

        public RegisterViewModel(UserRepository repo, Action loginWindow)
        {
            RegisterCommand = new RelayCommand(async fn => {
                if (Username == null || Password == null) {
                    MessageBox.Show("Minden mezõ kitöltése kötelezõ!");
                }
                else
                {
                    bool successRegister = await repo.RegisterUserAsync(new User { Username = Username, PasswordHash = BCrypt.Net.BCrypt.HashPassword(Password) });
                    if (successRegister)
                    {
                        MessageBox.Show("Sikeres regisztráció.");
                        loginWindow();
                    }
                }

               
            });

            LoginCommand = new RelayCommand(fn => loginWindow());
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}