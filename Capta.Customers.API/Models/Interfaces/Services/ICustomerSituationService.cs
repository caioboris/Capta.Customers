using Capta.Customers.API.Models.Entities;

namespace Capta.Customers.API.Models.Interfaces.Services
{
    internal interface ICustomerSituationService
    {
        Task<List<CustomerSituation>> GetAllCustomerSituations();
        Task<CustomerSituation> GetCustomerSituationById(int id);
        Task<List<CustomerSituation>> PostCustomerSituation(CustomerSituation request);
        Task<CustomerSituation> PutCustomerSituation(CustomerSituation request);
        Task<List<CustomerSituation>> DeleteCustomerSituation(int id);

    }
}
