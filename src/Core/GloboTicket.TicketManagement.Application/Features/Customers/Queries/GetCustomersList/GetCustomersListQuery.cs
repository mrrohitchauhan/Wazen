using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQuery : IRequest<Response<IEnumerable<CustomerListVm>>>
    {
    }
}
