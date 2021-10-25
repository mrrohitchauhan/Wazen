using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
