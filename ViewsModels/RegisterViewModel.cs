using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Data_management;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }

        public RegisterViewModel(UserRepository repo, Action loginWindow)
        {
            RegisterCommand = new RelayCommand(async _ =>
            {
                if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Minden mezõ kitöltése kötelezõ!");
                    return;
                }

                var newUser = new User { Username = Username, PasswordHash = BCrypt.Net.BCrypt.HashPassword(Password) };

                bool successRegister = await repo.RegisterUserAsync(newUser);
                if (successRegister)
                {
                    MessageBox.Show("Sikeres regisztráció.");
                    loginWindow();
                }
            });

            LoginCommand = new RelayCommand(_ => loginWindow());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
