using FluentValidation;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.UpdateCustomer
{
    class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(p => p.EnglishFirstName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
