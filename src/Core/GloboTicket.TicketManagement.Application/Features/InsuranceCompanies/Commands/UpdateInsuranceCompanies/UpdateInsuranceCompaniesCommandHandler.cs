using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.UpdateInsuranceCompanies
{
   public class UpdateInsuranceCompaniesCommandHandler : IRequestHandler<UpdateInsuranceCompaniesCommand, Response<Guid>>
    {
        private readonly IInsuranceCompaniesRepository _userRepsitory;
        private readonly IMapper _mapper;

        public UpdateInsuranceCompaniesCommandHandler(IMapper mapper, IInsuranceCompaniesRepository userRepository)
        {
            _mapper = mapper;
            _userRepsitory = userRepository;
        }

        public async Task<Response<Guid>> Handle(UpdateInsuranceCompaniesCommand request, CancellationToken cancellationToken)
        {

            var userToUpdate = await _userRepsitory.GetByIdAsync(request.ICID);

            if (userToUpdate == null)
            {
                throw new NotFoundException(nameof(GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies), request.ICID);
            }

            var validator = new UpdateInsuranceCompaniesCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, userToUpdate, typeof(UpdateInsuranceCompaniesCommand), typeof(GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies));

            await _userRepsitory.UpdateAsync(userToUpdate);

            return new Response<Guid>(request.ICID, "Updated successfully ");

        }
    }
}
