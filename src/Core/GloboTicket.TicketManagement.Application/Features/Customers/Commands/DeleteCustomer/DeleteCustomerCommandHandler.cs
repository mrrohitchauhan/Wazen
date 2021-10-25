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


namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.DeleteCustomer
{
    class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDataProtector _protector;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository, IDataProtectionProvider provider)
        {
            _customerRepository = customerRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            //var customerId = new Guid(_protector.Unprotect(request.ID));

            var customerToDelete = await _customerRepository.GetByIdAsync(request.ID);
            //var studentToDelete = await _studentRepository.GetByIdAsync(request.StudentId);
            if (customerToDelete == null)
            {
                throw new NotFoundException(nameof(Event), request.ID);
                //throw new NotFoundException(nameof(Event), request.StudentId);
            }

            await _customerRepository.DeleteAsync(customerToDelete);
            return Unit.Value;
        }
    }
}
