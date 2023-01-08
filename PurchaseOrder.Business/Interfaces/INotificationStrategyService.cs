namespace PurchaseOrder.Business.Interfaces {
    public interface INotificationStrategyService {
        Task<bool> SendNotificationAsync(string message);
    }
}
