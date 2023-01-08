using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Business.Services {
    public class PushNotificationService : INotificationStrategyService {
        public async Task<bool> SendNotificationAsync(string message) {
            // Send push notification
            return await Task.Run(() => { return true; });
        }
    }
}
