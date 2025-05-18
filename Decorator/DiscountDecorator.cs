using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBurgerApp.Decorator
{
    public class DiscountDecorator : OrderDecorator
    {
        private int DiscountValue { get; set; }
        public DiscountDecorator(IOrder rendeles, int discountValue) : base(rendeles) { 
            this.DiscountValue = discountValue;
        }

        public override string Data => base.Data + " (" + DiscountValue.ToString() + "% kedvezmény)";
        public override double Total => base.Total * (DiscountValue / 100);
    }
}
