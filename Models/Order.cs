using System;
using WpfBurgerApp.Decorator;

namespace WpfBurgerApp.Models
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public Sandwich Sandwich { get; set; }
        //public string Size { get; set; }
        public bool IsTakeaway { get; set; }
        public DateTime OrderedAt { get; set; }
        public string Data { get { return ""; } }
        public double Total { get { return 0; } }

        //public List<OrderItem> OrderItems { get; set; }

        //public bool IsPaid { get; set; }
    }
}