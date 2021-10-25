using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannerDetail
{
    public class GetHomePageBannerDetailQuery : IRequest<Response<HomePageBannerDetailVm>>
    {
        public Guid ID { get; set; }
    }
}
