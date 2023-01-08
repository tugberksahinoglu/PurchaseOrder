using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Business.Services {
    public class EmailNotificationService : INotificationStrategyService {
        public async Task<bool> SendNotificationAsync(string message) {
            // Send email notification
            return await Task.Run(() => { return true; });
        }
    }
}
