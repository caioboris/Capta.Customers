using Capta.Customers.API.Models.Entities;

namespace Capta.Customers.API.Models.Interfaces.Services
{
    internal interface ICustomerTypeService
    {
        Task<List<CustomerType>> GetAllCustomerTypes();
        Task<CustomerType> GetCustomerTypeById(int id);
        Task<List<CustomerType>> PostCustomerType(CustomerType request);
        Task<CustomerType> PutCustomerType(CustomerType request);
        Task<List<CustomerType>> DeleteCustomerType(int id);

    }
}
