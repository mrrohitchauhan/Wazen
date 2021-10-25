using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport
{
    public class GetStaticContentsExportQueryHandler : IRequestHandler<GetStaticContentsExportQuery, StaticContentExportFileVm>
    {
        private readonly IStaticContentRepository _staticContentRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetStaticContentsExportQueryHandler(IMapper mapper, IStaticContentRepository staticContentRepository, ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _staticContentRepository = staticContentRepository;
            _csvExporter = csvExporter;
        }

        public async Task<StaticContentExportFileVm> Handle(GetStaticContentsExportQuery request, CancellationToken cancellationToken)
        {
            var allStaticContents = _mapper.Map<List<StaticContentExportDto>>((await _staticContentRepository.ListAllAsync()).OrderBy(x => x.ID));

            var fileData = _csvExporter.ExportStaticContentsToCsv(allStaticContents);

            var staticContentExportFileDto = new StaticContentExportFileVm() { ContentType = "text/csv", Data = fileData, StaticContentExportFileName = $"{Guid.NewGuid()}.csv" };

            return staticContentExportFileDto;
        }
    }
}
