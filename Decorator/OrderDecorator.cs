using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBurgerApp.Decorator
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder rendeles;

        public OrderDecorator(IOrder rend)
        {
            rendeles = rend;
        }

        public virtual string Data { get { return this.rendeles.Data; } }
        public virtual double Total { get { return this.rendeles.Total; } }

    }
}
