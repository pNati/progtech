using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBurgerApp.Decorator
{
    internal class OrderItemDecorator : OrderDecorator
    {
        private string OrderItem { get; set; }
        private int Price { get; set; }
        public OrderItemDecorator(IOrder rendeles, string orderItem, int price) : base(rendeles)
        {
            this.OrderItem = orderItem;
            this.Price = price;
        }

        public override string Data => base.Data + OrderItem.ToString() + "\n";
        public override double Total => base.Total + Price;
    }
}
