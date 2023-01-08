using Microsoft.AspNetCore.Mvc;

namespace PurchaseOrder.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase {
        /// <summary>
        /// Get order's notification channels
        /// </summary>
        [HttpGet]
        [Route("{orderId}")]
        public async Task<IActionResult> Get(long orderId) {
            return Ok();
        }
    }
}
