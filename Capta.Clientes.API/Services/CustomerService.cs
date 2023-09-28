using Capta.Customers.API.Models.Entities;
using Capta.Customers.API.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capta.Customers.API.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<IActionResult> DeleteCustomers(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PostCustomer(Customer request)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> PutCustomer(Customer request)
        {
            throw new NotImplementedException();
        }
    }
}
