using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;

using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.CreateInsuranceCompanies
{
    class CreateInsuranceCompaniesCommandHandler : IRequestHandler<CreateInsuranceCompaniesCommand, Response<CreateInsuranceCompaniesDto>>
    {
        private readonly IInsuranceCompaniesRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateInsuranceCompaniesCommandHandler(IMapper mapper, IInsuranceCompaniesRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<Response<CreateInsuranceCompaniesDto>> Handle(CreateInsuranceCompaniesCommand request, CancellationToken cancellationToken)
        {
            var createUserCommandResponse = new Response<CreateInsuranceCompaniesDto>();

            var validator = new CreateInsuranceCompaniesCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createUserCommandResponse.Succeeded = false;
                createUserCommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createUserCommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var user = new GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies()
                {

                    NameoftheIC = request.NameoftheIC,
                NameofICAdmin = request.NameofICAdmin,
                ICAdminEmailAddress = request.ICAdminEmailAddress,
                ICAdminPassword = request.ICAdminPassword,
                ICAdminPhoneNumber = request.ICAdminPhoneNumber,
                StartDateofCollaboration = request.StartDateofCollaboration,
                Location = request.Location,
                City = request.City,
                OfficeNumber = request.OfficeNumber,
                Agreements = request.Agreements,
                NoofPolicies = request.NoofPolicies,
                ConfigurableParameters = request.ConfigurableParameters,
                AdminExpenseForNAJM = request.AdminExpenseForNAJM,
                AdminExpenseForELM = request.AdminExpenseForELM,
                BankFees = request.BankFees,
                DefaultExpenses = request.DefaultExpenses,
                SharingPercentageForCancellation = request.SharingPercentageForCancellation,
                SharingPercentageForAdministrationFees = request.SharingPercentageForAdministrationFees,
                CommissionAgreed = request.CommissionAgreed,
                APIAvailable = request.APIAvailable,
                EndpointURL = request.EndpointURL,
                RequestType = request.RequestType,
                Header = request.Header,
                Body = request.Body,
                CancelAPIAvailable = request.CancelAPIAvailable,
                CancelEndpointURL = request.CancelEndpointURL,
                CancelRequestType = request.CancelRequestType,
                CancelHeader = request.CancelHeader,
                CancelBody = request.CancelBody,
                RefundEndpointURL = request.RefundEndpointURL,
                RefundRequestType = request.RefundRequestType,
                RefundHeader = request.RefundHeader,
                RefundBody = request.RefundBody,
                AddOnsRemoveEndpointURL = request.AddOnsRemoveEndpointURL,
                AddOnsRemoveRequestType = request.AddOnsRemoveRequestType,
                AddOnsRemoveHeader = request.AddOnsRemoveHeader,
                AddOnsRemoveBody = request.AddOnsRemoveBody,
                AddOnsRemovePolicyPricing = request.AddOnsRemovePolicyPricing,
                IsActive =  Convert.ToBoolean(request.IsActive),
                ICCreatedBy = request.CreatedBy,
                CreatedOn = request.CreatedOn,
                ModifiedBy = request.ModifiedBy,
                ModifiedOn = request.ModifiedOn,
                };
                user = await _userRepository.AddAsync(user);
                createUserCommandResponse.Data = _mapper.Map<CreateInsuranceCompaniesDto>(user);
                createUserCommandResponse.Succeeded = true;
                createUserCommandResponse.Message = "success";
            }

            return createUserCommandResponse;
        }
    }
}
