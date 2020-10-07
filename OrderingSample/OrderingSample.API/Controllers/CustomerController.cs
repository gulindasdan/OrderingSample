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
    public class CustomerController : ControllerBase
    {
        protected readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            await _customerService.AddAsync(customer);
            return CreatedAtAction("Get", new { id = customer.Id }, customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Customer customer)
        {
            if (await _customerService.GetByIdAsync(customer.Id) != null)
            {
                return Ok(_customerService.UpdateAsync(customer));
            }
            return NotFound();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (await _customerService.GetByIdAsync(id) != null)
            {
                var deletedOrder = await _customerService.GetByIdAsync(id);
                await _customerService.RemoveAsync(deletedOrder);
                return Ok();
            }
            return NotFound();
        }
    }
}
