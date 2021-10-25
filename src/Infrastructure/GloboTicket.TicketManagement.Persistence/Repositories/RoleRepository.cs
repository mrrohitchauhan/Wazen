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
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly ILogger _logger;
        public RoleRepository(GloboTicketDbContext dbContext, ILogger<Role> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        /*public async Task<List<Role>> GetRoleWithEvents(bool includePassedEvents)
        {
            _logger.LogInformation("GetRoleWithvents Initiated");
            var allRoles = await _dbContext.Roles.Include(x => x.Roles).ToListAsync();
            if (!includePassedEvents)
            {
                allRoles.ForEach(p => p.Roles.ToList().RemoveAll(c => c.Date < DateTime.Today));
            }
            _logger.LogInformation("GetRolesWithEvents Completed");
            return allRoles;
        }*/
    }

}
