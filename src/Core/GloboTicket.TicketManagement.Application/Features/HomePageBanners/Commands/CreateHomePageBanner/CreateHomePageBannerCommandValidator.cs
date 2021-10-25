using FluentValidation;
using GloboTicket.TicketManagement.Features.HomePageBanners.Commands.CreateHomePageBanner;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.CreateHomePageBanner
{
    public class CreateHomePageBannerCommandValidator : AbstractValidator<CreateHomePageBannerCommand>
    {
        public CreateHomePageBannerCommandValidator()
        {
            RuleFor(p => p.ImageSource)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}
