using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Interfaces {
    public interface IOrderService {
        Task Create(CreateOrderRequest request);
        Task<GetOrderResponse?> GetByUserId(long userId);
    }
}
