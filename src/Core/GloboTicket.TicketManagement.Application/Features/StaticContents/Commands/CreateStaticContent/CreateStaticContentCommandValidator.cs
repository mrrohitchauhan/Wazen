using FluentValidation;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.CreateStaticContent
{
    public class CreateStaticContentCommandValidator : AbstractValidator<CreateStaticContentCommand>
    {
        public CreateStaticContentCommandValidator()
        {
            RuleFor(p => p.AboutUs)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}
