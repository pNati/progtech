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
            AppState.WhatDessert = "Palacsinta";
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            
            this.Close();
        }

        private void Donut_Click(object sender, RoutedEventArgs e)
        {
            AppState.WhatDessert = "Fánk";
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
           
            this.Close();
        }

        private void Icecream_Click(object sender, RoutedEventArgs e)
        {
            AppState.WhatDessert = "Fagylalt";
            var orderViewWindow = new OrderView();
            orderViewWindow.Show();
            this.Close();
        }


    }
}
