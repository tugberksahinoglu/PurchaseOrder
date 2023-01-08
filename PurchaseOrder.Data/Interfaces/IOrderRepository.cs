using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Data.Interfaces {
    public interface IOrderRepository {
        Task Create(CreateOrderRequest request);
        Task Delete(long orderId);
        Task<GetOrderResponse?> GetByUserId(long userId);
    }
}
