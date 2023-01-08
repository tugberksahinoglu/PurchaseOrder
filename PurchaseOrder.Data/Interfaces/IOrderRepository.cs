using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Data.Interfaces {
    public interface IOrderRepository {
        Task<long> CreateAsync(Order order);
        Task DeleteAsync(long orderId);
        Task<Order?> GetByUserIdAsync(long userId);
    }
}
