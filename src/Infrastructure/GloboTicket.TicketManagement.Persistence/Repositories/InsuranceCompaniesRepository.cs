using Microsoft.Extensions.Logging;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;


namespace GloboTicket.TicketManagement.Persistence.Repositories
{ 

    public class InsuranceCompaniesRepository : BaseRepository<InsuranceCompanies>,IInsuranceCompaniesRepository
    {
        private readonly ILogger _logger;
        public InsuranceCompaniesRepository(GloboTicketDbContext dbContext, ILogger<InsuranceCompanies> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }
    }
}
