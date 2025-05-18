using System;
using WpfBurgerApp.Decorator;

namespace WpfBurgerApp.Models
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsTakeaway { get; set; }
        public DateTime OrderedAt { get; set; }
        public string Data { get { return ""; } }
        public double Total { get { return 0; } }

        public Order GetBaseOrder() => this;

        public override string ToString()
        {
            return $"Azonos�t�: { Id }, Adatok: {Data}, �sszesen: {Total}, Elviteles: {IsTakeaway}";
        }
    }
}