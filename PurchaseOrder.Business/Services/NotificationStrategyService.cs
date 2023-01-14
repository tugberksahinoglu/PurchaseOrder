using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Business.Services {
    public class NotificationStrategyService {
        private readonly List<INotificationStrategyService> _notificationStrategies;
        private readonly NotificationLogService _notificationLogService;
        public NotificationStrategyService(List<INotificationStrategyService> notificationStrategies, NotificationLogService notificationLogService) {
            _notificationStrategies = notificationStrategies;
            _notificationLogService = notificationLogService;
        }

        public async Task SendNotificationAsync(string message) {
            foreach (var strategy in _notificationStrategies) {
                if (await strategy.SendNotificationAsync(message)) {
                    await _notificationLogService.AddAsync(new() {
                        Channel =  Model.Enums.NotificationChannel.Sms, //TODO: Get it from strategy
                        Message = message
                    });
                }
                else {
                    //TODO: Log to txt file 
                }
            }
        }
    }
}
