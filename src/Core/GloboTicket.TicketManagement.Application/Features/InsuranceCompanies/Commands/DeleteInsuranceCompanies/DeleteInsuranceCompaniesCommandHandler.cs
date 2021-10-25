using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.DeleteInsuranceCompanies
{
  public class DeleteInsuranceCompaniesCommandHandler : IRequestHandler<DeleteInsuranceCompaniesCommand>
    {
        private readonly IInsuranceCompaniesRepository _userRepsitory;
        
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public DeleteInsuranceCompaniesCommandHandler(IInsuranceCompaniesRepository userRepsitory, IDataProtectionProvider provider)
        {
            _userRepsitory = userRepsitory;

           
        }

        public async Task<Unit> Handle(DeleteInsuranceCompaniesCommand request, CancellationToken cancellationToken)
        {
           var userToDelete = await _userRepsitory.GetByIdAsync(request.ICID);

            if (userToDelete == null)
            {
                throw new NotFoundException(nameof(GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies), request.ICID);
            }

            await _userRepsitory.DeleteAsync(userToDelete);
            return Unit.Value;
        }

    }
}
