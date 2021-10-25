using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannerDetail
{
    public class GetHomePageBannerDetailQueryHandler : IRequestHandler<GetHomePageBannerDetailQuery, Response<HomePageBannerDetailVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<HomePageBanner> _homePageBannerRepository;
        private readonly IMapper _mapper;

        private readonly IDataProtector _protector;
        public GetHomePageBannerDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<HomePageBanner> homePageBannerRepository, IDataProtectionProvider provider)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _homePageBannerRepository = homePageBannerRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Response<HomePageBannerDetailVm>> Handle(GetHomePageBannerDetailQuery request, CancellationToken cancellationToken)
        {
            //string ID = _protector.Unprotect(request.ID);

            //var homePageBanner = await _eventRepository.GetByIdAsync(new Guid(ID));

            var homePageBanner = await _homePageBannerRepository.GetByIdAsync(request.ID);
            var homePageBannerDetailDto = _mapper.Map<HomePageBannerDetailVm>(homePageBanner);

            /*var homePageBanner = await _homePageBannerRepository.GetByIdAsync(@event.ID);

            if (homePageBanner == null)
            {
                throw new NotFoundException(nameof(Event), request.ID);
            }
            eventDetailDto.HomePageBanner = _mapper.Map<HomePageBannerDto>(homePageBanner);
            */
            var response = new Response<HomePageBannerDetailVm>(homePageBannerDetailDto);
            return response;
        }
    }
}
