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
using WpfBurgerApp.ViewModels;
using WpfBurgerApp.ViewsModels;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
            var dbContext = new AppDbContext();
            var userRepo = new UserRepository(dbContext);
            DataContext = new RegisterViewModel(userRepo, OpenLogin);
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel vm)
            {
                vm.Password = ((PasswordBox)sender).Password;
            }
        }

        private void OpenLogin()
        {
            var loginWindow = new LoginView();
            loginWindow.Show();
            this.Close();
        }
    }
}
