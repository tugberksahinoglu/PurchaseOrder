using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Interfaces {
    public interface IOrderService {
        Task Create(CreateOrderRequest request);
        Task Delete(long orderId);
        Task<GetOrderResponse?> GetByUserId(long userId);
    }
}
