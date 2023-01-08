using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Data.Interfaces;
using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Business.Services {
    public class NotificationService : INotificationService {
        private readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository) {
            _notificationRepository = notificationRepository;
        }
        public async Task CreateAsync(long orderId, List<CreateNotificationRequest>? notificationRequests) {
            if (notificationRequests is null) {
                throw new ArgumentNullException(nameof(notificationRequests));
            }

            List<Notification> notifications = new();
            foreach (var request in notificationRequests) {
                notifications.Add(new() {
                    Channel = request.Channel,
                    OrderId = orderId,
                });
            }
            await _notificationRepository.CreateAsync(notifications);
        }

        public async Task<List<GetNotificationResponse>?> GetAsync(long orderId) {
            List<GetNotificationResponse>? notificationResponses = new();
            var notifications = await _notificationRepository.GetAsync(orderId);
            if (notifications is not null) {
                //TODO: use AutoMapper
                foreach (var notification in notifications) {
                    notificationResponses.Add(new() {
                        Channel = notification.Channel,
                    });
                } 
            }
            return notificationResponses;
        }
    }
}
