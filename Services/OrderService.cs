using WpfBurgerApp.Data;
using WpfBurgerApp.Models;

namespace WpfBurgerApp.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepo;
        public OrderService(OrderRepository repo) => _orderRepo = repo;
        public Order? PlaceOrder(Order order) => _orderRepo.Add(order);
        public void CancelOrder(Order order) => _orderRepo.Remove(order);

        public IQueryable<Order> GetAllOrder() => _orderRepo.GetAll();
    }
}