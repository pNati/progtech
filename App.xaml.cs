using System.Windows;
using WpfBurgerApp.Data;
using WpfBurgerApp.Views;

namespace WpfBurgerApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }

}
