using CsvHelper;
using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersExport;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport;
using System.Collections.Generic;
using System.IO;

namespace GloboTicket.TicketManagement.Infrastructure
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }

        byte[] ICsvExporter.ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            throw new System.NotImplementedException();
        }

        byte[] ICsvExporter.ExportHomePageBannersToCsv(List<HomePageBannerExportDto> homePageBannerExportDtos)
        {
            throw new System.NotImplementedException();
        }

        byte[] ICsvExporter.ExportStaticContentsToCsv(List<StaticContentExportDto> staticContentExportDtos)
        {
            throw new System.NotImplementedException();
        }
    }
}
