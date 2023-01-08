using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Business.Services {
    public class SmsNotificationService : INotificationStrategyService {
        public async Task<bool> SendNotificationAsync(string message) {
            // Send sms notification
            return await Task.Run(() => { return true; });
        }
    }
}
