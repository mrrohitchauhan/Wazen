using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Features.HomePageBanners.Commands.CreateHomePageBanner;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.CreateHomePageBanner
{
    public class CreateHomePageBannerCommandHandler : IRequestHandler<CreateHomePageBannerCommand, Response<CreateHomePageBannerDto>>
    {
        private readonly IHomePageBannerRepository _homePageBannerRepository;
        private readonly IMapper _mapper;

        public CreateHomePageBannerCommandHandler(IMapper mapper, IHomePageBannerRepository homePageBannerRepository)
        {
            _mapper = mapper;
            _homePageBannerRepository = homePageBannerRepository;
        }

        public async Task<Response<CreateHomePageBannerDto>> Handle(CreateHomePageBannerCommand request, CancellationToken cancellationToken)
        {
            var createHomePageBannerCommandResponse = new Response<CreateHomePageBannerDto>();

            var validator = new CreateHomePageBannerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createHomePageBannerCommandResponse.Succeeded = false;
                createHomePageBannerCommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createHomePageBannerCommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var homePageBanner = new HomePageBanner() { 
                    ImageSource = request.ImageSource, 
                    ProductID = request.ProductID,
                    IsActive = request.IsActive,
                    CreatedBy = request.CreatedBy,
                    CreatedOn = request.CreatedOn,
                    ModifiedBy = request.ModifiedBy,
                    ModifiedOn = request. ModifiedOn
                };
                homePageBanner = await _homePageBannerRepository.AddAsync(homePageBanner);
                createHomePageBannerCommandResponse.Data = _mapper.Map<CreateHomePageBannerDto>(homePageBanner);
                createHomePageBannerCommandResponse.Succeeded = true;
                createHomePageBannerCommandResponse.Message = "success";
            }

            return createHomePageBannerCommandResponse;
        }
    }
}
