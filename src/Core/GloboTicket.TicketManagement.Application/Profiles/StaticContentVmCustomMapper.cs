using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsList;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.AspNetCore.DataProtection;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class StaticContentVmCustomMapper : ITypeConverter<StaticContent, StaticContentListVm>
    {
        private readonly IDataProtector _protector;

        public StaticContentVmCustomMapper(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("");
        }
        public StaticContentListVm Convert(StaticContent source, StaticContentListVm destination, ResolutionContext context)
        {
            StaticContentListVm dest = new StaticContentListVm()
            {
                //ID = _protector.Protect(source.ID.ToString()),
                ID=source.ID,
                AboutUs = source.AboutUs,
                TermsAndCondition = source.TermsAndCondition,
                PartnerName = source.PartnerName,
                PartnerLogo = source.PartnerLogo,
                RedirectedURL = source.RedirectedURL,
                Status = source.Status,
                NameOfTheCompany =source.NameOfTheCompany,
                Address = source.Address,
                ContactNo = source.ContactNo,
                EmailAddress = source.EmailAddress,
                SocialMediaIcon = source.SocialMediaIcon,
                SocialMediaLink = source.SocialMediaLink,
                WebsiteLink = source.WebsiteLink,
                GoogleLocation = source.GoogleLocation
            };

            return dest;

        }
    }
}
