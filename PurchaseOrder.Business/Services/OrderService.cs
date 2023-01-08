using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Services {
    public class OrderService : IOrderService {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        public OrderService(IOrderRepository orderRepository, INotificationService notificationService) {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
        }

        public async Task CreateAsync(CreateOrderRequest request) {
            if (await GetByUserIdAsync(request.UserId) is not null) {
                throw new Exception("You have an active order, if you want to create new order please delete your active order first.");
            }

            //TODO: use AutoMapper
            Order order = new() {
                Amount = request.Amount,
                DayOfMonth = request.DayOfMonth,
                UserId = request.UserId,
            };
            long orderId = await _orderRepository.CreateAsync(order);
            await _notificationService.CreateAsync(orderId, request.Notifications);
        }

        public async Task<GetOrderResponse?> GetByUserIdAsync(long userId) {
            GetOrderResponse? response = default;

            //TODO: use AutoMapper
            var order = await _orderRepository.GetByUserIdAsync(userId);
            if (order is not null) {
                response = new() {
                    Amount = order.Amount,
                    DayOfMonth = order.DayOfMonth,
                };
            }
            return response;
        }

        public async Task DeleteAsync(long orderId) {
            await _orderRepository.DeleteAsync(orderId);
        }
    }
}
