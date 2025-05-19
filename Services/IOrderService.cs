using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Services
{
    public interface IOrderService
    {
        public Order? PlaceOrder(Order order);
    }
}
