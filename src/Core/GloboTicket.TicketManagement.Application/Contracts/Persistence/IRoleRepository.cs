using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IRoleRepository : IAsyncRepository<Role>
    {
        //Task<List<Role>> GetRolesWithEvents(bool includePassedEvents);
    }
    
}
