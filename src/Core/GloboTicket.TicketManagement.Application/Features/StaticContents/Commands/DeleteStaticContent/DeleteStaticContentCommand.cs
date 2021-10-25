using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.DeleteStaticContent
{
    public class DeleteStaticContentCommand : IRequest
    {
        public Guid ID { get; set; }
    }
}
