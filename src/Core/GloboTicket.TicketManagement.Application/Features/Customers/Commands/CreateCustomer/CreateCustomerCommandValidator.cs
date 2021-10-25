
using FluentValidation;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.CreateCustomer
{
    class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
                RuleFor(p => p.EnglishFirstName)
                   .NotEmpty().WithMessage("{PropertyName} is required.")
                   .NotNull()
                   .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
        }

    }
}
