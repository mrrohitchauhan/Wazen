using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands.CreateCustomer;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Response<CreateCustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<Response<CreateCustomerDto>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var createStudentCommandResponse = new Response<CreateCustomerDto>();

            var validator = new CreateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createStudentCommandResponse.Succeeded = false;
                createStudentCommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createStudentCommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var customer = new Customer() { Salutation = request.Salutation, EnglishFirstName = request.EnglishFirstName, EnglishMiddleName=request.EnglishMiddleName, EnglishLastName=request.EnglishLastName, ArabicFirstName=request.ArabicFirstName, ArabicMiddleName=request.ArabicMiddleName, ArabicLastName=request.ArabicLastName, Address=request.Address, NationalID=request.NationalID, IQAMA=request.IQAMA, CompanyCR=request.CompanyCR, Email=request.Email, Mobile=request.Mobile, TelephoneNumber=request.TelephoneNumber, Gender=request.Gender, Occupation=request.Occupation, EducationID=request.EducationID, MaritalStatusID=request.MaritalStatusID, IsActive=request.IsActive, ModifiedBy=request.ModifiedBy, DriverID=request.DriverID,DateOfBirth=request.DateOfBirth};
                customer = await _customerRepository.AddAsync(customer);
                createStudentCommandResponse.Data = _mapper.Map<CreateCustomerDto>(customer);
                createStudentCommandResponse.Succeeded = true;
                createStudentCommandResponse.Message = "success";
            }

            return createStudentCommandResponse;
        }
    }
}
