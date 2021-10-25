using GloboTicket.TicketManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        //Task<List<Student>> GetStudentsWithEvents(bool includePassedEvents);
    }
}
