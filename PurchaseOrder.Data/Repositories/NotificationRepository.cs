using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;

namespace PurchaseOrder.Data.Repositories {
    public class NotificationRepository : INotificationRepository {
        private readonly DataContext _dbContext;
        public NotificationRepository(DataContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(List<Notification> notifications) {
            await _dbContext.AddRangeAsync(notifications);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Notification>?> GetAsync(long orderId) {
            return await _dbContext.Notifications.Where(n => n.OrderId == orderId).ToListAsync();
        }
    }
}
