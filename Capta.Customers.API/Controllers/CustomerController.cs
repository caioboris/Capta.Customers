using Capta.Customers.API.Models.Entities;
using Capta.Customers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capta.Clientes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;


        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(Name = "GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok(await _customerService.GetAllCustomersAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var result = await _customerService.GetCustomerByIdAsync(id);

            if(result == null)
                return NotFound("Customer not found");
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostCustomer(Customer body)
        {
            return Ok(await _customerService.PostCustomerAsync(body));
        }

        [HttpPut]
        public async Task<IActionResult> PutCostumer(Customer body)
        {
            var result = await _customerService.PutCustomerAsync(body);

            if (result == null)
                return NotFound("Customer not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await _customerService.DeleteCustomersAsync(id);

            if (result == null)
                return NotFound("Customer not found");

            return Ok(result);
        }

    }
}