using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersList
{
    public class GetHomePageBannersListQuery : IRequest<Response<IEnumerable<HomePageBannerListVm>>>
    {
    }
}
