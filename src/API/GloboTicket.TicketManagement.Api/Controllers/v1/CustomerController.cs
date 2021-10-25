using GloboTicket.TicketManagement.Api.Utility;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands.DeleteCustomer;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands.UpdateCustomer;
using GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomerDetail;
using GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomersList;

using GloboTicket.TicketManagement.Application.Responses;
//using GloboTicket.TicketManagement.Application.Features.Students.Queries.GetStudentsListWithEvents;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public CustomerController(IMediator mediator, ILogger<CustomerController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("all", Name = "GetAllCustomers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllCustomers()
        {
            _logger.LogInformation("GetAllCustomers Initiated");
            var dtos = await _mediator.Send(new GetCustomersListQuery());
            _logger.LogInformation("GetCustomers Completed");
            return Ok(dtos);


        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public async Task<ActionResult> GetCustomerById(Guid id)
        {
            var getCustomerDetailQuery = new GetCustomerDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getCustomerDetailQuery));
        }

        [HttpPost(Name = "AddCustomer")]
        public async Task<ActionResult> Create([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            _logger.LogInformation("AddCustomer Initiated");
            var response = await _mediator.Send(createCustomerCommand);
            _logger.LogInformation("AddCustomer Completed");
            return Ok(response);
        }

        [HttpPut(Name = "UpdateCustomer")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateCustomerCommand updateCustomerCommand)
        {
            _logger.LogInformation("UpdateCustomer Initiated");
            var response = await _mediator.Send(updateCustomerCommand);
            _logger.LogInformation("UpdateCustomer Completed");
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var deleteStudentCommand = new DeleteCustomerCommand() { /*ID = id*/ID = System.Guid.Parse(id) };
            _logger.LogInformation("DeleteCustomer Initiated");
            await _mediator.Send(deleteStudentCommand);
            _logger.LogInformation("DeleteCustomer Completed");
            return NoContent();
        }
    }
}
