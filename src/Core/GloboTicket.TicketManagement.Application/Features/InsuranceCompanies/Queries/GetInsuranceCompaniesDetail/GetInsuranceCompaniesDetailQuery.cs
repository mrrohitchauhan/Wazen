using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System.Collections.Generic;
using System;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesDetail
{
    public class GetInsuranceCompaniesDetailQuery : IRequest<Response<InsuranceCompaniesDetailVm>>
    {
        public Guid ICID { get; set; }
    }
}
