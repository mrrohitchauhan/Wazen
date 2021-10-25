using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.UpdateHomePageBanner
{
    public class UpdateHomePageBannerCommandHandler : IRequestHandler<UpdateHomePageBannerCommand, Response<Guid>>
    {
        private readonly IHomePageBannerRepository _homePageBannerRepository;
        private readonly IMapper _mapper;

        public UpdateHomePageBannerCommandHandler(IMapper mapper, IHomePageBannerRepository homePageBannerRepository)
        {
            _mapper = mapper;
            _homePageBannerRepository = homePageBannerRepository;
        }

        public async Task<Response<Guid>> Handle(UpdateHomePageBannerCommand request, CancellationToken cancellationToken)
        {
            //var homePageBannerId = new Guid(_protector.Unprotect(request.ID));
            //var homePageBannerToUpdate = await _homePageBannerRepository.GetByIdAsync(homePageBannerId);
            var homePageBannerToUpdate = await _homePageBannerRepository.GetByIdAsync(request.ID);

            if (homePageBannerToUpdate == null)
            {
                //throw new NotFoundException(nameof(HomePageBanner), homePageBannerId);
                throw new NotFoundException(nameof(HomePageBanner), request.ID);
            }

            var validator = new UpdateHomePageBannerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, homePageBannerToUpdate, typeof(UpdateHomePageBannerCommand), typeof(HomePageBanner));

            await _homePageBannerRepository.UpdateAsync(homePageBannerToUpdate);

            return new Response<Guid>(request.ID, "Updated successfully ");
        }
    }
}
