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

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersExport
{
    public class GetHomePageBannersExportQueryHandler : IRequestHandler<GetHomePageBannersExportQuery, HomePageBannerExportFileVm>
    {
        private readonly IHomePageBannerRepository _homePageBannerRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetHomePageBannersExportQueryHandler(IMapper mapper, IHomePageBannerRepository homePageBannerRepository, ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _homePageBannerRepository = homePageBannerRepository;
            _csvExporter = csvExporter;
        }

        public async Task<HomePageBannerExportFileVm> Handle(GetHomePageBannersExportQuery request, CancellationToken cancellationToken)
        {
            var allHomePageBanners = _mapper.Map<List<HomePageBannerExportDto>>((await _homePageBannerRepository.ListAllAsync()).OrderBy(x => x.ID));

            var fileData = _csvExporter.ExportHomePageBannersToCsv(allHomePageBanners);

            var customerLoginExportFileDto = new HomePageBannerExportFileVm() { ContentType = "text/csv", Data = fileData, HomePageBannerExportFileName = $"{Guid.NewGuid()}.csv" };

            return customerLoginExportFileDto;
        }
    }
}
