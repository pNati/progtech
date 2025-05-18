using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBurgerApp.Decorator
{
    public interface IOrder
    {
        string Data { get; }
        double Total { get; }
    }
}
