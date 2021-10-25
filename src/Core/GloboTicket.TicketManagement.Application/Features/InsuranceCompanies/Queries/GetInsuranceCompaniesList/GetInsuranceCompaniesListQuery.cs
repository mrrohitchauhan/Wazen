using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesList;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesList
{
    public class GetInsuranceCompaniesListQuery : IRequest<Response<IEnumerable<InsuranceCompaniesListVm>>>
    {
    }
}
