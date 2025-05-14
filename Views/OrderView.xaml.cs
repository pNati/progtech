using System.Windows.Controls;

namespace WpfBurgerApp.Views
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Page
    {
        string selected = AppState.SelectedMeat;
        // pl.: MessageBox.Show("Kiválasztott hús: " + selected);
        string size = AppState.SelectedSize;

        public OrderView()
        {
            InitializeComponent();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
