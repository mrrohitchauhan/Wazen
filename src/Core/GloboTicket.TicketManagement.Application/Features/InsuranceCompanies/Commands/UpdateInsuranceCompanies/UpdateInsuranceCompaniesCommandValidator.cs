using FluentValidation;
using System;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.UpdateInsuranceCompanies
{
    class UpdateInsuranceCompaniesCommandValidator : AbstractValidator<UpdateInsuranceCompaniesCommand>
    {
        public UpdateInsuranceCompaniesCommandValidator()
        {
            RuleFor(p => p.NameoftheIC)
                    .NotEmpty().WithMessage("{PropertyName} is required.")
                    .NotNull()
                    .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");

            RuleFor(p => p.NameofICAdmin)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.ICAdminEmailAddress)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.ICAdminPassword)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.ICAdminPhoneNumber)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.StartDateofCollaboration)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Location)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.City)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.OfficeNumber)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Agreements)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.NoofPolicies)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.ConfigurableParameters)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AdminExpenseForNAJM)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AdminExpenseForELM)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.BankFees)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.DefaultExpenses)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.SharingPercentageForCancellation)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.SharingPercentageForAdministrationFees)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CommissionAgreed)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.APIAvailable)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.EndpointURL)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.RequestType)
               .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Header)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Body)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CancelAPIAvailable)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CancelEndpointURL)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CancelRequestType)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CancelHeader)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.CancelBody)
               .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.RefundEndpointURL)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.RefundRequestType)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.RefundHeader)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.RefundBody)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AddOnsRemoveEndpointURL)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AddOnsRemoveRequestType)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AddOnsRemoveHeader)
               .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.AddOnsRemoveBody)
             .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.AddOnsRemovePolicyPricing)
               .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.IsActive)
              .NotEmpty().WithMessage("{PropertyName} is required.");
            
            RuleFor(p => p.CreatedOn)
               .NotEmpty().WithMessage("{PropertyName} is required.")
             .NotNull()
                .GreaterThan(DateTime.Now);
            RuleFor(p => p.ModifiedBy)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.ModifiedOn)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);


        }
    }
}
