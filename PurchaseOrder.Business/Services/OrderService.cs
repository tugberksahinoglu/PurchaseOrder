using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Services {
    public class OrderService : IOrderService {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository) {
            _orderRepository = orderRepository;
        }

        public async Task Create(CreateOrderRequest request) {
            if (await GetByUserId(request.UserId) is not null) {
                throw new Exception("You have an active order, if you want to create new order please delete your active order first.");
            }

            await _orderRepository.Create(request);
        }

        public async Task<GetOrderResponse?> GetByUserId(long userId) {
            return await _orderRepository.GetByUserId(userId);
        }
    }
}
