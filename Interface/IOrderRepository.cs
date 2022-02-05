using PieShop.Models;

namespace PieShop.Interface
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
