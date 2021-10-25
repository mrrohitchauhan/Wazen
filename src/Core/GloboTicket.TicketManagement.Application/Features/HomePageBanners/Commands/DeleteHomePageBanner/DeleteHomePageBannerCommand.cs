using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.DeleteHomePageBanner
{
    public class DeleteHomePageBannerCommand : IRequest
    {
        public Guid ID { get; set; }
    }
}
