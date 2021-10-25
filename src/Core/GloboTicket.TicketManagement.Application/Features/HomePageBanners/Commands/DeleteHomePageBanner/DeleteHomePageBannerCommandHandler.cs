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

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.DeleteHomePageBanner
{
    public class DeleteHomePageBannerCommandHandler : IRequestHandler<DeleteHomePageBannerCommand>
    {
        private readonly IHomePageBannerRepository _homePageBannerRepository;
        private readonly IDataProtector _protector;

        public DeleteHomePageBannerCommandHandler(IHomePageBannerRepository homePageBannerRepository, IDataProtectionProvider provider)
        {
            _homePageBannerRepository = homePageBannerRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Unit> Handle(DeleteHomePageBannerCommand request, CancellationToken cancellationToken)
        {
            //var homePagebannerId = new Guid(_protector.Unprotect(request.ID));
            //var homePageBannerToDelete = await _studentRepository.GetByIdAsync(homePageBannerId);
            var homePageBannerToDelete = await _homePageBannerRepository.GetByIdAsync(request.ID);
            if (homePageBannerToDelete == null)
            {
                //throw new NotFoundException(nameof(Event), homePageBannerToDelete);
                throw new NotFoundException(nameof(Event), request.ID);
            }

            await _homePageBannerRepository.DeleteAsync(homePageBannerToDelete);
            return Unit.Value;
        }
    }
}
