using System.ComponentModel.DataAnnotations;

namespace PurchaseOrder.Model
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public byte DayOfMonth { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public long UserId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
