using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBurgerApp
{
        public static class AppState
        {
            public static string SelectedSize { get; set; }
            public static string SelectedMeat { get; set; }
            public static string SelectedDrink { get; set;} //át kell írni enumra ezeket TODO!!!
            public static bool Dessert { get; set;}
            public static string WhatDessert { get; set;}
        }
}
