using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Entities;


namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.UpdateCustomer
{
   public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Response<Guid>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<Response<Guid>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {

            var customerToUpdate = await _customerRepository.GetByIdAsync(request.ID);

            if (customerToUpdate == null)
            {
                throw new NotFoundException(nameof(Customer), request.ID);
            }

            var validator = new UpdateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, customerToUpdate, typeof(UpdateCustomerCommand), typeof(Customer));

            await _customerRepository.UpdateAsync(customerToUpdate);

            return new Response<Guid>(request.ID, "Updated successfully ");

        }
    }
}
