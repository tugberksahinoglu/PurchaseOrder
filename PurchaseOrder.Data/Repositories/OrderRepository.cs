using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Data.Repositories {
    public class OrderRepository : IOrderRepository {
        private readonly DataContext _dbContext;

        public OrderRepository(DataContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task Create(CreateOrderRequest request) {
            //TODO: use AutoMapper
            Order order = new() {
                Amount = request.Amount,
                DayOfMonth = request.DayOfMonth,
                UserId = request.UserId,
            };
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<GetOrderResponse?> GetByUserId(long userId) {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.IsActive && o.UserId == userId);
            //TODO: use AutoMapper
            GetOrderResponse? response = default;
            if (order is not null) {
                response = new() {
                    Amount = order.Amount,
                    DayOfMonth = order.DayOfMonth,
                };
            }
            return response;
        }
    }
}
