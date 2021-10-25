using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQuery : IRequest<Response<UserDetailVm>>
    {
        public Guid Id { get; set; }
    }
}
