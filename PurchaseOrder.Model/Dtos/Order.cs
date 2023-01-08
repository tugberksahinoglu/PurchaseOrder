using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model.Dtos {
    public record CreateOrderRequest {
        [Required]
        public byte DayOfMonth { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public long UserId { get; set; }
        public List<CreateNotificationRequest>? Notifications { get; set; }
    }

    public record GetOrderResponse {
        public byte DayOfMonth { get; set; }
        public decimal Amount { get; set; }
    }
}
