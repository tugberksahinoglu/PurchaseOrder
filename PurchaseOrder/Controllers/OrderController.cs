using Microsoft.AspNetCore.Mvc;
using PurchaseOrder.Business.Interfaces;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService) {
            _orderService = orderService;
        }
        /// <summary>
        /// Add new order
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateOrderRequest order) {
            await _orderService.CreateAsync(order);
            return Ok();
        }

        /// <summary>
        /// Get user's active orders
        /// </summary>
        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetAsync(long userId) {
            return Ok(await _orderService.GetByUserIdAsync(userId));
        }

        /// <summary>
        /// Delete order
        /// </summary>
        [HttpDelete]
        [Route("{orderId}")]
        public async Task<IActionResult> DeleteAsync(long orderId) {
            await _orderService.DeleteAsync(orderId);
            return Ok();
        }
    }
}
