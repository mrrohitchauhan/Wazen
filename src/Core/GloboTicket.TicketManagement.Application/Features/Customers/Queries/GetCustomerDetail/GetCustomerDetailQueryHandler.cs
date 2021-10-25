using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, Response<CustomerDetailVm>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerDetailQueryHandler(IMapper mapper, ICustomerRepository customerRepository, ILogger<GetCustomerDetailQueryHandler> logger)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;

        }
        public async Task<Response<CustomerDetailVm>> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);

            var customerDetailDto = _mapper.Map<CustomerDetailVm>(customer);


            var response = new Response<CustomerDetailVm>(customerDetailDto);

            return response;
        }


    }
}
