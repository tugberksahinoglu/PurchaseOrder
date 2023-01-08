using Microsoft.AspNetCore.Mvc;
using PurchaseOrder.Business.Interfaces;

namespace PurchaseOrder.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService) {
            _notificationService = notificationService;
        }
        /// <summary>
        /// Get order's notification channels
        /// </summary>
        [HttpGet]
        [Route("{orderId}")]
        public async Task<IActionResult> GetAsync(long orderId) {
            return Ok(await _notificationService.GetAsync(orderId));
        }
    }
}
