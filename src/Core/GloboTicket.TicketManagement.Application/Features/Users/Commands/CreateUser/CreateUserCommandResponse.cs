using GloboTicket.TicketManagement.Application.Responses;

namespace GloboTicket.TicketManagement.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandResponse
    {
        public CreateUserCommandResponse()
        {

        }

        public CreateUserDto User { get; set; }
    }
}