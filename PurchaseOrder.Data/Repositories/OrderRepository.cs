using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;

namespace PurchaseOrder.Data.Repositories {
    public class OrderRepository : IOrderRepository {
        private readonly DataContext _dbContext;

        public OrderRepository(DataContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<long> CreateAsync(Order order) {

            await _dbContext.Orders.AddAsync(order);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Order?> GetByUserIdAsync(long userId) {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.IsActive && o.UserId == userId);
            return order;
        }

        public async Task DeleteAsync(long orderId) {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.IsActive && o.Id == orderId);
            if (order is not null) {
                order.IsActive = false;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
