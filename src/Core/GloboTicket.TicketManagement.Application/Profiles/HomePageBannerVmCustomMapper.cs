using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersList;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.AspNetCore.DataProtection;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class HomePageBannerVmCustomMapper : ITypeConverter<HomePageBanner, HomePageBannerListVm>
    {
        private readonly IDataProtector _protector;

        public HomePageBannerVmCustomMapper(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("");
        }
        public HomePageBannerListVm Convert(HomePageBanner source, HomePageBannerListVm destination, ResolutionContext context)
        {
            HomePageBannerListVm dest = new HomePageBannerListVm()
            {
                /*ID = _protector.Protect(source.ID.ToString()),*/
                ID = source.ID,
                ImageSource = source.ImageSource,
                ProductID = source.ProductID,
                IsActive = source.IsActive,
                CreatedBy = source.CreatedBy,
                CreatedOn = source.CreatedOn,
                ModifiedBy = source.ModifiedBy,
                ModifiedOn = source.ModifiedOn
            };

            return dest;

        }
    }
}
