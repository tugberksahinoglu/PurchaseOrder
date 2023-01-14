using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Data.Repositories;
using PurchaseOrder.Model;

namespace PurchaseOrder.Business.Services {
    public class NotificationLogService : INotificationLogService {
        private readonly NotificationLogRepository _notificationLogRepository;
        public NotificationLogService(NotificationLogRepository notificationLogRepository) {
            _notificationLogRepository = notificationLogRepository;
        }

        public async Task AddAsync(NotificationLog notificationLog) {
            await _notificationLogRepository.AddAsync(notificationLog);
        }
    }
}
