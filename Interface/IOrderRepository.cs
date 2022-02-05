using PieShop.Models;

namespace PieShop.Interface
{
    /// <summary>
    /// Interface for create order
    /// </summary>
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
