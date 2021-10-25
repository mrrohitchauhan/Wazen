using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsList
{
    public class GetStaticContentsListQuery : IRequest<Response<IEnumerable<StaticContentListVm>>>
    {
    }
}
