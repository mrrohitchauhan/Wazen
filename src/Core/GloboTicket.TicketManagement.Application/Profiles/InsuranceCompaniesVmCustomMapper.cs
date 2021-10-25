using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesDetail;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesList;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.AspNetCore.DataProtection;


namespace GloboTicket.TicketManagement.Application.Profiles
{
     public class InsuranceCompaniesVmCustomMapper : ITypeConverter<GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies, InsuranceCompaniesListVm>
    {
        private readonly IDataProtector _protector;

        public InsuranceCompaniesVmCustomMapper(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("");
        }
        public InsuranceCompaniesListVm Convert(GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies source, InsuranceCompaniesListVm destination, ResolutionContext context)
        {
            InsuranceCompaniesListVm dest = new InsuranceCompaniesListVm()
            {
                ICID= source.ICID,
                NameoftheIC = source.NameoftheIC,
                NameofICAdmin = source.NameofICAdmin,
                ICAdminEmailAddress = source.ICAdminEmailAddress,
                ICAdminPassword = source.ICAdminPassword,
                ICAdminPhoneNumber = source.ICAdminPhoneNumber,
                StartDateofCollaboration = source.StartDateofCollaboration,
                Location = source.Location,
                City = source.City,
                OfficeNumber = source.OfficeNumber,
                Agreements = source.Agreements,
                NoofPolicies = source.NoofPolicies,
                ConfigurableParameters = source.ConfigurableParameters,
                AdminExpenseForNAJM = source.AdminExpenseForNAJM,
                AdminExpenseForELM = source.AdminExpenseForELM,
                BankFees = source.BankFees,
                DefaultExpenses = source.DefaultExpenses,
                SharingPercentageForCancellation = source.SharingPercentageForCancellation,
                SharingPercentageForAdministrationFees = source.SharingPercentageForAdministrationFees,
                CommissionAgreed = source.CommissionAgreed,
                APIAvailable = source.APIAvailable,
                EndpointURL = source.EndpointURL,
                RequestType = source.RequestType,
                Header = source.Header,
                Body = source.Body,
                CancelAPIAvailable = source.CancelAPIAvailable,
                CancelEndpointURL = source.CancelEndpointURL,
                CancelRequestType = source.CancelRequestType,
                CancelHeader = source.CancelHeader,
                CancelBody = source.CancelBody,
                RefundEndpointURL = source.RefundEndpointURL,
                RefundRequestType = source.RefundRequestType,
                RefundHeader = source.RefundHeader,
                RefundBody = source.RefundBody,
                AddOnsRemoveEndpointURL = source.AddOnsRemoveEndpointURL,
                AddOnsRemoveRequestType = source.AddOnsRemoveRequestType,
                AddOnsRemoveHeader = source.AddOnsRemoveHeader,
                AddOnsRemoveBody = source.AddOnsRemoveBody,
                AddOnsRemovePolicyPricing = source.AddOnsRemovePolicyPricing,
                IsActive = source.IsActive,
                CreatedBy = source.ICCreatedBy,
                CreatedOn = source.CreatedOn,
                ModifiedBy = source.ModifiedBy,
                ModifiedOn = source.ModifiedOn,
            };

            return dest;

        }
    }
}
