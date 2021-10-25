using GloboTicket.TicketManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery : IRequest<Response<CustomerDetailVm>>
    {
        public Guid Id { get; set; }
    }
}
