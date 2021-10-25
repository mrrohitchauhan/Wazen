using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList
{
    public class GetRolesListQueryHandler : IRequestHandler<GetRolesListQuery, Response<IEnumerable<RoleListVm>>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public GetRolesListQueryHandler(IMapper mapper, IRoleRepository roleRepository, ILogger<GetRolesListQueryHandler> logger)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
            _logger = logger;
        }

        public async Task<Response<IEnumerable<RoleListVm>>> Handle(GetRolesListQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allRoles = (await _roleRepository.ListAllAsync()).OrderBy(x => x.RoleName);
            var role = _mapper.Map<IEnumerable<RoleListVm>>(allRoles);
            _logger.LogInformation("Hanlde Completed");
            return new Response<IEnumerable<RoleListVm>>(role, "success");
        }

    }
}
