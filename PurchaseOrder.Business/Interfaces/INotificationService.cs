using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Interfaces {
    public interface INotificationService {
        Task CreateAsync(long orderId, List<CreateNotificationRequest>? notifications);
        Task<List<GetNotificationResponse>?> GetAsync(long orderId);
    }
}
