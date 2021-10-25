using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloboTicket.Application.Features.Roles.Commands.CreateRole;
using GloboTicket.Application.Features.Roles.Commands.DeleteRole;
using GloboTicket.Application.Features.Roles.Commands.UpdateRole;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRoleDetail;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GloboTicket.TicketManagement.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public RoleController(IMediator mediator, ILogger<RoleController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

      [HttpGet("all", Name = "GetAllRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllRoles()
        {
            _logger.LogInformation("GetAllRoles Initiated");
            var dtos = await _mediator.Send(new GetRolesListQuery());
            _logger.LogInformation("GetAllRoles Completed");
            return Ok(dtos);
        }

        [HttpPut(Name = "UpdateRole")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateRoleCommand updateEventCommand)
        {
            _logger.LogInformation("UpdateEvent Initiated");

            var response = await _mediator.Send(updateEventCommand);
            _logger.LogInformation("UpdateEvent Completed");
            return Ok(response);


        }


        [HttpPost(Name = "AddRole")]
        public async Task<ActionResult> Create([FromBody] CreateRoleCommand createRoleCommand)
        {
            var response = await _mediator.Send(createRoleCommand);
            return Ok(response);
        }


        [HttpDelete("{id}", Name = "DeleteRole")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            _logger.LogInformation("deleteAllRoles Initiated");

            var deleteRoleCommand = new DeleteRoleCommand() { Id = id };
            await _mediator.Send(deleteRoleCommand);
            _logger.LogInformation("deleteAllRoles Completed");

            return NoContent();
        }

        [HttpGet("{id}", Name = "GetRoleById")]
        public async Task<ActionResult> GetRoletById(Guid id)
        {
            var getRoleDetailQuery = new GetRoleDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getRoleDetailQuery));
        }




    }
}
