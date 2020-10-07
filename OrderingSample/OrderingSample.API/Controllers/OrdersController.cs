using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingSample.Business.Abstract;
using OrderingSample.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderingSample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        protected readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if(order != null)
            {
                return Ok(order);
            }
            return NotFound();
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            await _orderService.AddAsync(order);
            return CreatedAtAction("Get", new { id = order.Id }, order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Order order)
        {
            if (await _orderService.GetByIdAsync(order.Id) != null)
            {
                await _orderService.UpdateAsync(order);
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(string id)
        {
            if (await _orderService.GetByIdAsync(id) != null)
            {
                var deletedOrder = await _orderService.GetByIdAsync(id);
                await _orderService.RemoveAsync(deletedOrder);
                return Ok();
            }
            return NotFound();
        }
    }
}
