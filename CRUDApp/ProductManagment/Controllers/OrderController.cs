using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;
using ProductManagment.Services.Interface;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
           var res =  await _orderService.GetAllOrders();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult>AddOrder( Order order)
        {
            await _orderService.AddOrder(order);
            return Ok();
        }
        
    }
}
