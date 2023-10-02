using Capta.Customers.API.Data;
using Capta.Customers.API.Models;
using Capta.Customers.API.Models.Entities;
using Capta.Customers.API.Models.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Capta.Customers.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> DeleteCustomersAsync(int id)
        {
            var customer = await _context.Customer.FindAsync(id);

            if (customer == null) return null;

            _context.Customer.Remove(customer);
            return await _context.Customer.ToListAsync();
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)   
        {
            var customer = await _context.Customer.FindAsync(id);

            if (customer == null) return null;

            return customer;
        }

        public async Task<List<Customer>> PostCustomerAsync(Customer request)
        {
            _context.Customer.Add(request);
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> PutCustomerAsync(Customer request)
        {
            var customer = await _context.Customer.FindAsync(request.Id);

            if (customer == null) return null;

            customer.Name = request.Name;
            customer.CPF = request.CPF;
            customer.Situation = request.Situation;
            customer.Gender = request.Gender;
            customer.Type= request.Type;
            await _context.SaveChangesAsync();
            
            return customer;
        }
    }
}
