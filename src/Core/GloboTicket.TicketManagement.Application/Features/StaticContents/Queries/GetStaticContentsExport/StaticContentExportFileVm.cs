
namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport
{
    public class StaticContentExportFileVm
    {
        public string StaticContentExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
