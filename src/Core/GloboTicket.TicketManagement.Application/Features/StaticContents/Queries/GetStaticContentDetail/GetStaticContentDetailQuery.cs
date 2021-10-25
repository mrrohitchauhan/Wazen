using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentDetail
{
    public class GetStaticContentDetailQuery : IRequest<Response<StaticContentDetailVm>>
    {
        public Guid ID { get; set; }
    }
}
