using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.DeleteInsuranceCompanies
{
   public class DeleteInsuranceCompaniesCommand : IRequest
    {

        public Guid ICID { get; set; }
    }
}
