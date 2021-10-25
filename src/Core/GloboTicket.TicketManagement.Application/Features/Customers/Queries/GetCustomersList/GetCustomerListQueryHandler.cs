using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomersListQuery, Response<IEnumerable<CustomerListVm>>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public GetCustomerListQueryHandler(IMapper mapper, ICustomerRepository customerRepository, ILogger<GetCustomerListQueryHandler> logger)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _logger = logger;
        }

        public async Task<Response<IEnumerable<CustomerListVm>>> Handle(GetCustomersListQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allCustomers = (await _customerRepository.ListAllAsync()).OrderBy(x => x.ID);
            var customer = _mapper.Map<IEnumerable<CustomerListVm>>(allCustomers);
            _logger.LogInformation("Hanlde Completed");
            return new Response<IEnumerable<CustomerListVm>>(customer, "success");
        }

    }
}
