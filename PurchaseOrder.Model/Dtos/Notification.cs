using PurchaseOrder.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model.Dtos
{
    public record CreateNotificationRequest
    {
        [Required]
        public NotificationChannel Channel { get; set; }
    }

    public record GetNotificationResponse {
        public NotificationChannel Channel { get; set; }    
    }
}
