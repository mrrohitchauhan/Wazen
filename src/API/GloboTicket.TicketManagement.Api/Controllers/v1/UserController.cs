using GloboTicket.TicketManagement.Application.Features.Users.Commands.CreateUser;
using GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUsersList;
using GloboTicket.TicketManagement.Application.Features.Users.Commands.UpdateUser;

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.Users.Commands.DeleteUser;
using GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUserDetail;

namespace GloboTicket.TicketManagement.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public UserController(IMediator mediator, ILogger<UserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        //[Authorize]
        [HttpGet("all", Name = "GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllUsers()
        {
            _logger.LogInformation("GetAllUsers Initiated");
            var dtos = await _mediator.Send(new GetUsersListQuery());
            _logger.LogInformation("GetAllUsers Completed");
            return Ok(dtos);
        }
        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult> GetUserById(Guid id)
        {
            var getUserDetailQuery = new GetUserDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getUserDetailQuery));
        }


        //[Authorize]
        /*[HttpGet("allwithevents", Name = "GetWithEvents")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]*/
        /*public async Task<ActionResult> GetStudentsWithEvents(bool includeHistory)
        {
            GetStudentsListWithEventsQuery getStudentsListWithEventsQuery = new GetStudentsListWithEventsQuery() { IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(getStudentsListWithEventsQuery);
            return Ok(dtos);
        }*/

        [HttpPut(Name = "UpdateUser")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateUserCommand updateEventCommand)
        {
            _logger.LogInformation("UpdateEvent Initiated");

            var response = await _mediator.Send(updateEventCommand);
            _logger.LogInformation("UpdateEvent Completed");
            return Ok(response);


        }

        [HttpPost(Name = "AddUser")]
        public async Task<ActionResult> Create([FromBody] CreateUserCommand createUserCommand)
        {
            var response = await _mediator.Send(createUserCommand);
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteUser")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            _logger.LogInformation("deleteAllUsers Initiated");

            var deleteUserCommand = new DeleteUserCommand() { Id = id };
            await _mediator.Send(deleteUserCommand);
            _logger.LogInformation("deleteAllUsers Completed");

            return NoContent();
        }


    }
}
