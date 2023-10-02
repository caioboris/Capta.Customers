using Capta.Customers.API.Data;
using Capta.Customers.API.Models.Entities;
using Capta.Customers.API.Models.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Capta.Customers.API.Services
{
    public class CustomerSituationService : ICustomerSituationService
    {
        private readonly DataContext _context;

        public CustomerSituationService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerSituation>> DeleteCustomerSituation(int id)
        {
            var customer = await _context.CustomerSituation.FindAsync(id);

            if (customer == null) return null;

            _context.CustomerSituation.Remove(customer);
            return await _context.CustomerSituation.ToListAsync();
        }

        public async Task<List<CustomerSituation>> GetAllCustomerSituations()
        {
            return await _context.CustomerSituation.ToListAsync();
        }

        public async Task<CustomerSituation> GetCustomerSituationById(int id)   
        {
            var customer = await _context.CustomerSituation.FindAsync(id);

            if (customer == null) return null;

            return customer;
        }

        public async Task<List<CustomerSituation>> PostCustomerSituation(CustomerSituation request)
        {
            _context.CustomerSituation.Add(request);
            return await _context.CustomerSituation.ToListAsync();
        }

        public async Task<CustomerSituation> PutCustomerSituation(CustomerSituation request)
        {
            var customer = await _context.CustomerSituation.FindAsync(request.Id);

            if (customer == null) return null;

            customer.Situation = request.Situation;
            await _context.SaveChangesAsync();
            
            return customer;
        }
    }
}
