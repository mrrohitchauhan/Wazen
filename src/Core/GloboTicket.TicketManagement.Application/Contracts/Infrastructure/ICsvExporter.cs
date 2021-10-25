using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersExport;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
        byte[] ExportStaticContentsToCsv(List<StaticContentExportDto> staticContentExportDtos);
        byte[] ExportHomePageBannersToCsv(List<HomePageBannerExportDto> homePageBannerExportDtos);
    }
}
