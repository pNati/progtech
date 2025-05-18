using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBurgerApp.Views
{
    public partial class Thank : Window
    {
        public Thank()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }
    }
}
