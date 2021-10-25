using MediatR;
using GloboTicket.TicketManagement.Application.Responses;
using System.Collections.Generic;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList
{
    public class GetRolesListQuery : IRequest<Response<IEnumerable<RoleListVm>>>
    {
        public Guid Id { get; set; }
    }
}
