using GloboTicket.TicketManagement.Domain.Entities;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
   
        public interface IInsuranceCompaniesRepository : IAsyncRepository<InsuranceCompanies>
        {
            //  Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
            //Task GetInsuranceCompaniesListWithEventsQuery(bool includeHistory);
        }
    
}
