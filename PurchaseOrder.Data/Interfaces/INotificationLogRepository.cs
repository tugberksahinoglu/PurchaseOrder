using PurchaseOrder.Model;

namespace PurchaseOrder.Data.Interfaces {
    public interface INotificationLogRepository {
        Task AddAsync(NotificationLog notificationLog);
    }
}
