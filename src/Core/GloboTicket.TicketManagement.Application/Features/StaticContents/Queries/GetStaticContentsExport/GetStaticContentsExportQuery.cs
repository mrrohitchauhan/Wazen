using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport
{
    public class GetStaticContentsExportQuery : IRequest<StaticContentExportFileVm>
    {
    }
}
