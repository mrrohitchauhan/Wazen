using MediatR;
using System;

namespace GloboTicket.Application.Features.Roles.Commands.DeleteRole
{
   public  class DeleteRoleCommand : IRequest
    {
        public Guid Id { get; set; }
    }
        
}
