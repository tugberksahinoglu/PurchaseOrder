using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Business.Services {
    public class NotificationStrategyService {
        private readonly List<INotificationStrategyService> _notificationStrategies;
        public NotificationStrategyService(List<INotificationStrategyService> notificationStrategies) {
            _notificationStrategies = notificationStrategies;
        }

        public async Task SendNotificationAsync(string message) {
            foreach (var strategy in _notificationStrategies) {
                if (await strategy.SendNotificationAsync(message)) {
                    //TODO: Log notification sent time to NotificationLog
                }
                else {
                    //TODO: Log to txt file 
                }
            }
        }
    }
}
