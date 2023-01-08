using Microsoft.AspNetCore.Mvc;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase {
        /// <summary>
        /// Add new order
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Order order) {
            return Ok();
        }

        /// <summary>
        /// Get user's active orders
        /// </summary>
        [HttpGet]
        [Route("{userId}")]
        public IActionResult Get(long userId) {
            return Ok();
        }

        /// <summary>
        /// Delete order
        /// </summary>
        [HttpDelete]
        [Route("{orderId}")]
        public IActionResult Delete(long orderId) {
            return Ok();
        }
    }
}
