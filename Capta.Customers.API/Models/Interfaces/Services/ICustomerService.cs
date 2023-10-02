using Capta.Customers.API.Models.Entities;

namespace Capta.Customers.API.Models.Interfaces.Services
{
    internal interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<List<Customer>> PostCustomerAsync(Customer request);
        Task<Customer> PutCustomerAsync(Customer request);
        Task<List<Customer>> DeleteCustomersAsync(int id);

    }
}
