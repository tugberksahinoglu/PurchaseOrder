using PurchaseOrder.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model
{
    public class Notification
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public NotificationChannel Channel { get; set; }
        [Required]
        public long OrderId { get; set; }
    }
}
