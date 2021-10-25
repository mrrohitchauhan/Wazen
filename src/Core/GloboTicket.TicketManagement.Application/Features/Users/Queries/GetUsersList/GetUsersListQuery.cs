using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<Response<IEnumerable<UserListVm>>>
    {
    }
}
