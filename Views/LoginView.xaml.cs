using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfBurgerApp.Data;
using WpfBurgerApp.Data_management;
using WpfBurgerApp.Services;
using WpfBurgerApp.ViewsModels;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            var regView = new RegisterView();
            InitializeComponent();
            var dbContext = new AppDbContext();
            var userRepo = new UserRepository(dbContext);
            DataContext = new LoginViewModel(new AuthService(userRepo), OpenRegister, OpenStartView);
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel vm)
            {
                vm.Password = ((PasswordBox)sender).Password;
            }
        }

        private void OpenRegister()
        {
            var regWindow = new RegisterView();
            regWindow.Show();
            this.Close();
        }

        private void OpenStartView() {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }
    }
}
