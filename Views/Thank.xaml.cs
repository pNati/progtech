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
        internal void Show() => throw new NotImplementedException();

        private void New_Click(object sender, EventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }
    }
}
