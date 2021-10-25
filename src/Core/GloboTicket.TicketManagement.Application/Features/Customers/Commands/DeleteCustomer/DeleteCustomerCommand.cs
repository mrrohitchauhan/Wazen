using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Customers.Commands.DeleteCustomer
{
   public  class DeleteCustomerCommand : IRequest
    {
        public Guid ID { get; set; }
    }
}
