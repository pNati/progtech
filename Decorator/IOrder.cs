using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Decorator
{
    public interface IOrder
    {
        string Data { get; }
        double Total { get; }
        Order GetBaseOrder();
    }
}
