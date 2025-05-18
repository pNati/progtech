using Microsoft.EntityFrameworkCore;
using System.Windows;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Data
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) => _context = context;

        public Order? Add(Order order) {
            var ujOrder = order;
            _context.Orders.Add(ujOrder);
            try
            {
                _context.SaveChanges();
                return ujOrder;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba mentéskor: " + ex.Message);
            }
            return null;
             
        }
        public void Remove(Order order) { _context.Orders.Remove(order); _context.SaveChanges(); }
        public IQueryable<Order> GetAll() => _context.Orders;
    }
}