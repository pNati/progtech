using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfBurgerApp.Views
{
    public partial class OrderView : Window
    {
        public OrderView()
        {
            InitializeComponent();
            DisplayOrderSummary();
        }

        private void DisplayOrderSummary()
        {
            // Összeg kiszámítása
            int total = 0;
            string summary = "";

            // Méret alapján ár
            switch (AppState.SelectedSize)
            {
                case "Small":
                    total += 1000;
                    summary += "Méret: Kicsi\n";
                    break;
                case "Medium":
                    total += 1500;
                    summary += "Méret: Közepes\n";
                    break;
                case "Large":
                    total += 2500;
                    summary += "Méret: Nagy\n";
                    break;
            }

            // Hús választás
            if (!string.IsNullOrEmpty(AppState.SelectedMeat))
                summary += $"Hús: {AppState.SelectedMeat}\n";

            // Ital választás
            if (!string.IsNullOrEmpty(AppState.SelectedDrink))
                summary += $"Ital: {AppState.SelectedDrink}\n";

            // Desszert választás
            if (AppState.Dessert)
            {
                summary += $"Desszert: {AppState.WhatDessert}\n";
                switch (AppState.WhatDessert)
                {
                    case "Palacsinta":
                        total += 800;
                        break;
                    case "Fánk":
                        total += 500;
                        break;
                    case "Fagylalt":
                        total += 700;
                        break;
                }
            }
            else
            {
                summary += "Desszert: Nincs\n";
            }

            // Kiírás a TextBox-okba
            OrderSummaryTextBox.Text = summary;
            TotalTextBox.Text = $"Összeg: {total} Ft";
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
    }
}
