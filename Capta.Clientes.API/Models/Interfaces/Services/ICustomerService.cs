using Capta.Customers.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Capta.Customers.API.Models.Interfaces.Services
{
    internal interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<IActionResult> PostCustomer(Customer request);
        Task<Customer> PutCustomer(Customer request);
        Task<IActionResult> DeleteCustomers(int id);

    }
}
