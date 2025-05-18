using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBurgerApp.Views
{
    public partial class Dessert: Window
    {
        public Dessert()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }
        private void Pancakes_Click(object sender, RoutedEventArgs e)
        {
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            AppState.WhatDessert = "Pancakes";
            this.Close(); ;
        }

        private void Donut_Click(object sender, RoutedEventArgs e)
        {
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            AppState.WhatDessert = "Donut";
            this.Close();
        }

        private void Icecream_Click(object sender, RoutedEventArgs e)
        {
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            AppState.WhatDessert = "Icecream";
            this.Close();
        }


    }
}
