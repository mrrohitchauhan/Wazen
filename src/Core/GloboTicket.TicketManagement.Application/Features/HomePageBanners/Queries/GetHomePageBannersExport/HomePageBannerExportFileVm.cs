
namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersExport
{
    public class HomePageBannerExportFileVm
    {
        public string HomePageBannerExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
