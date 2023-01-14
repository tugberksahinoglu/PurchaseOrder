using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;

namespace PurchaseOrder.Data.Repositories {
    public class NotificationLogRepository : INotificationLogRepository {
        private readonly DataContext _dbContext;
        public NotificationLogRepository(DataContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task AddAsync(NotificationLog notificationLog) {
            await _dbContext.AddAsync(notificationLog);
            await _dbContext.SaveChangesAsync();
        }
    }
}
