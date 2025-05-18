using System;
using System.Windows;
using System.Windows.Controls;
using WpfBurgerApp.Data;
using WpfBurgerApp.Data_management;
using WpfBurgerApp.Decorator;
using WpfBurgerApp.Models;
using WpfBurgerApp.Services;
using WpfBurgerApp.ViewModels;
using WpfBurgerApp.ViewsModels;

namespace WpfBurgerApp.Views
{
    public partial class OrderView : Window
    {
        public OrderView()
        {
            InitializeComponent();
            DisplayOrderSummary();
            var dbContext = new AppDbContext();
            var orderRepo = new OrderRepository(dbContext);
            DataContext = new OrderViewModel(new OrderService(orderRepo), OpenThankView);
        }

        private void DisplayOrderSummary()
        {
            AppState.Order = new Order();

            // Összeg kiszámítása
            int sizePrice = 0;

            // Méret alapján ár
            switch (AppState.SelectedSize)
            {
                case "Kicsi":
                    sizePrice = 1000;
                    break;
                case "Közepes":
                    sizePrice = 1500;
                    break;
                case "Nagy":
                    sizePrice = 2500;
                    break;
            }
            AppState.Order = new OrderItemDecorator(AppState.Order, $"Méret: {AppState.SelectedSize}", sizePrice);

            // Hús választás
            if (!string.IsNullOrEmpty(AppState.SelectedMeat))
            {
                AppState.Order = new OrderItemDecorator(AppState.Order, $"Hús: {AppState.SelectedMeat}", 0);
            }

            // Ital választás
            if (!string.IsNullOrEmpty(AppState.SelectedDrink)) {
                AppState.Order = new OrderItemDecorator(AppState.Order, $"Ital: {AppState.SelectedDrink}", 0);
            }

            int dessertPrice = 0;
            // Desszert választás
            if (AppState.Dessert)
            {
                switch (AppState.WhatDessert)
                {
                    case "Palacsinta":
                        dessertPrice = 800;
                        break;
                    case "Fánk":
                        dessertPrice = 500;
                        break;
                    case "Fagylalt":
                        dessertPrice = 700;
                        break;
                }
                AppState.Order = new OrderItemDecorator(AppState.Order, $"Desszert: {AppState.WhatDessert}",dessertPrice);
            }

            OrderSummaryTextBox.Text = AppState.Order.Data;
            TotalTextBox.Text = $"Összeg: {AppState.Order.Total} Ft";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var startWindow = new StartView();
            startWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // nem szükséges semmi ide
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = isTakeawayCheckbox.IsChecked;

            AppState.isTakeaway = (bool)isChecked;
            var payWindow = new Pay();
            payWindow.Show();
            this.Close();
        }
        private void OpenThankView()
        {
            var loginWindow = new Thank();
            loginWindow.Show();
            this.Close();
        }
    }

  
}
