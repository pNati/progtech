using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBurgerApp.Decorator;
using WpfBurgerApp.Models;

namespace WpfBurgerApp
{
        public static class AppState
        {
            public static User User { get; set; }
            public static IOrder Order { get; set; } 
            public static string SelectedSize { get; set; }
            public static string SelectedMeat { get; set; }
            public static string PaymentMethod { get; set; }
            public static string SelectedDrink { get; set;} //át kell írni enumra ezeket TODO!!!
            public static bool Dessert { get; set;}
            public static bool isTakeaway { get; set; }
            public static string WhatDessert { get; set;}
        }
}
