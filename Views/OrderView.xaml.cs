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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBurgerApp.WpfBurgerApp;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Page
    {
        string selected = AppState.SelectedMeat;
        // pl.: MessageBox.Show("Kiválasztott hús: " + selected);

        public OrderView()
        {
            InitializeComponent();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
