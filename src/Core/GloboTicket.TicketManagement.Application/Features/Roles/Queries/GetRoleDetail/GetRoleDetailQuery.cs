using MediatR;
using GloboTicket.TicketManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRoleDetail
{
  public class GetRoleDetailQuery : IRequest<Response<RoleDetailVm>>
    {
        public Guid Id { get; set; }
    }

}
