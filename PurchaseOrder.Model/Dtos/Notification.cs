using PurchaseOrder.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model.Dtos
{
    public class Notification
    {
        [Required]
        public NotificationChannel Channel { get; set; }
    }
}
