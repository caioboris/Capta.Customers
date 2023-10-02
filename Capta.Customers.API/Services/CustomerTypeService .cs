using Capta.Customers.API.Data;
using Capta.Customers.API.Models.Entities;
using Capta.Customers.API.Models.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Capta.Customers.API.Services
{
    public class CustomerTypeService : ICustomerTypeService
    {
        private readonly DataContext _context;

        public CustomerTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerType>> DeleteCustomerType(int id)
        {
            var customerType = await _context.CustomerType.FindAsync(id);

            if (customerType == null) return null;

            _context.CustomerType.Remove(customerType);
            return await _context.CustomerType.ToListAsync();
        }

        public async Task<List<CustomerType>> GetAllCustomerTypes()
        {
            return await _context.CustomerType.ToListAsync();
        }

        public async Task<CustomerType> GetCustomerTypeById(int id)   
        {
            var customerType = await _context.CustomerType.FindAsync(id);

            if (customerType == null) return null;

            return customerType;
        }

        public async Task<List<CustomerType>> PostCustomerType(CustomerType request)
        {
            _context.CustomerType.Add(request);
            return await _context.CustomerType.ToListAsync();
        }

        public async Task<CustomerType> PutCustomerType(CustomerType request)
        {
            var customerType = await _context.CustomerType.FindAsync(request.Id);

            if (customerType == null) return null;

            customerType.Type= request.Type;
            await _context.SaveChangesAsync();
            
            return customerType;
        }
    }
}
