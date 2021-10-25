using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Application.Features.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommand : IRequest<Response<Guid>>
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
        public string RoleArabicName { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}
