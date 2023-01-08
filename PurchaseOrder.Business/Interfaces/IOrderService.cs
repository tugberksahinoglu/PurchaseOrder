using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Interfaces {
    public interface IOrderService {
        Task CreateAsync(CreateOrderRequest request);
        Task DeleteAsync(long orderId);
        Task<GetOrderResponse?> GetByUserIdAsync(long userId);
    }
}
