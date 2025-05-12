using System.ComponentModel;
using System.Windows.Input;
using WpfBurgerApp.Data;
using WpfBurgerApp.Commands;
using WpfBurgerApp.Models;
using WpfBurgerApp.Data_management;

namespace WpfBurgerApp.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand RegisterCommand { get; }

        public RegisterViewModel(UserRepository repo)
        {
            RegisterCommand = new RelayCommand(_ => repo.Add(new User { Username = Username, PasswordHash = Password }));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}