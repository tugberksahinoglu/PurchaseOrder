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
        public async Task<IActionResult> Create(CreateOrderRequest order) {
            await _orderService.Create(order);
            return Ok();
        }

        /// <summary>
        /// Get user's active orders
        /// </summary>
        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> Get(long userId) {
            return Ok(await _orderService.GetByUserId(userId));
        }

        /// <summary>
        /// Delete order
        /// </summary>
        [HttpDelete]
        [Route("{orderId}")]
        public async Task<IActionResult> Delete(long orderId) {
            await _orderService.Delete(orderId);
            return Ok();
        }
    }
}
