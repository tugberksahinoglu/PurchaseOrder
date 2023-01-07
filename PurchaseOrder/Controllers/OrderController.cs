using Microsoft.AspNetCore.Mvc;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase {
        [HttpPost]        
        public IActionResult Add(Order order) {
            return Ok();
        }
    }
}
