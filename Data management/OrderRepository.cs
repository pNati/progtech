using WpfBurgerApp.Models;

namespace WpfBurgerApp.Data
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) => _context = context;

        public void Add(Order order) { _context.Orders.Add(order); _context.SaveChanges(); }
        public void Remove(Order order) { _context.Orders.Remove(order); _context.SaveChanges(); }
        public IQueryable<Order> GetAll() => _context.Orders.Include(o => o.Sandwich).Include(o => o.User);
    }
}