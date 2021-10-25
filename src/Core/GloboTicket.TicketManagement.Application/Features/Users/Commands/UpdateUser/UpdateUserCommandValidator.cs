using FluentValidation;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
               // .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");

            RuleFor(p => p.Username)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date);
            /* .NotEmpty().WithMessage("{PropertyName} is required.")
             .NotNull()
             .GreaterThan(DateTime.Now);*/


            RuleFor(p => p.CreatedOn);
/*                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);
*/


            RuleFor(p => p.ContactNo)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Designation)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.ModifiedOn);
                /*.NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);*/



            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.IsActive)
               .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.CreatedBy);
            //  .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.ModifiedBy);
              // .NotEmpty().WithMessage("{PropertyName} is required.");


        }
    }
}
