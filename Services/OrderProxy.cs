using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Services
{
    public class OrderProxy : IOrderService
    {
        private readonly IOrderService relService;

        public OrderProxy(IOrderService service)
        {
            relService = service;
        }

        public Order? PlaceOrder(Order order)
        {
            if (string.IsNullOrWhiteSpace(order.Data))
            {
                Console.WriteLine("Hiba: A rendelési lista nem lehet üres!");
                return null;
            }

            Console.WriteLine($"[LOG] Rendelés naplózva.");

            return relService.PlaceOrder(order);
        }
    }
}
