using PurchaseOrder.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model {
    public class NotificationLog {
        [Key]
        public long Id { get; set; }
        [Required]
        public NotificationChannel Channel { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime SentDateTime { get; set; }
    }
}
