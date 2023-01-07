using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model.Dtos {
    public record Order {
        [Required]
        public byte DayOfMonth { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public long UserId { get; set; }
        public List<Notification>? Notifications { get; set; }
    }
}
