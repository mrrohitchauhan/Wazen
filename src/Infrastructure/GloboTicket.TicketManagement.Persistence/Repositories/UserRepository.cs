using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        private readonly ILogger _logger;
        public UserRepository(GloboTicketDbContext dbContext, ILogger<User> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        /* public async Task<List<Student>> GetStudentsWithEvents(bool includePassedEvents)
         {
             _logger.LogInformation("GetStudentsWithEvents Initiated");
             var allStudents = await _dbContext.Students.Include(x => x.Events).ToListAsync();
             if (!includePassedEvents)
             {
                 allStudents.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date < DateTime.Today));
             }
             _logger.LogInformation("GetStudentssWithEvents Completed");
             return allStudents;
         }*/
    }
}
