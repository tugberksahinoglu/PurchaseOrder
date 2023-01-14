using PurchaseOrder.Model;

namespace PurchaseOrder.Business.Interfaces {
    public interface INotificationLogService {
        Task AddAsync(NotificationLog notificationLog);
    }
}
