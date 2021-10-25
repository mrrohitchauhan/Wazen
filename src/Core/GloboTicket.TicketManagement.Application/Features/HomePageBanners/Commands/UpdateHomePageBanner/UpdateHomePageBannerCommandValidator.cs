using FluentValidation;

namespace GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.UpdateHomePageBanner
{
    public class UpdateHomePageBannerCommandValidator : AbstractValidator<UpdateHomePageBannerCommand>
    {
        public UpdateHomePageBannerCommandValidator()
        {
            RuleFor(p => p.ImageSource)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.ProductID)
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
