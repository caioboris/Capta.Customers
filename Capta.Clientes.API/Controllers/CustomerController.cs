using Capta.Customers.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Capta.Clientes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {


        public CustomerController()
        {
        }

        [HttpGet(Name = "GetAllCustomers")]
        public async Task<List<Customer>> GetAllCustomers()
        {
            return new List<Customer>();
        }
    }
}