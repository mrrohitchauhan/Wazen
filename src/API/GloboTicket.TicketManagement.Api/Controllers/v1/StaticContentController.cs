using GloboTicket.TicketManagement.Api.Utility;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.CreateStaticContent;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.DeleteStaticContent;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.UpdateStaticContent;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentDetail;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsExport;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class StaticContentController : ControllerBase
    {       
       
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public StaticContentController(IMediator mediator, ILogger<StaticContentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        //[Authorize]
        [HttpGet("all", Name = "GetAllStaticContents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllStaticContents()
        {
            _logger.LogInformation("GetAllStaticContents Initiated");
            var dtos = await _mediator.Send(new GetStaticContentsListQuery());
            _logger.LogInformation("GetAllStaticContents Completed");
            return Ok(dtos);
        }

        [HttpPost(Name = "AddStaticContent")]
        public async Task<ActionResult> Create([FromBody] CreateStaticContentCommand createStaticContentCommand)
        {
            _logger.LogInformation("AddStaticContent Initiated");
            var response = await _mediator.Send(createStaticContentCommand);
            _logger.LogInformation("AddStaticContent Completed");
            return Ok(response);
        }

        [HttpPut(Name = "UpdateStaticContent")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateStaticContentCommand updateStaticContentCommand)
        {
            _logger.LogInformation("UpdateStaticContent Initiated");
            var response = await _mediator.Send(updateStaticContentCommand);
            _logger.LogInformation("UpdateStaticContent Completed");
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteStaticContent")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var deleteStaticContentCommand = new DeleteStaticContentCommand() { ID = /*id*/System.Guid.Parse(id) };
            _logger.LogInformation("DeleteStaticContent Initiated");
            await _mediator.Send(deleteStaticContentCommand);
            _logger.LogInformation("DeleteStaticContent Completed");
            return NoContent();
        }

        [HttpGet("export", Name = "ExportStaticContents")]
        [FileResultContentType("text/csv")]
        public async Task<FileResult> ExportStaticContents()
        {
            _logger.LogInformation("ExportStaticContents Initiated");
            var fileDto = await _mediator.Send(new GetStaticContentsExportQuery());
            _logger.LogInformation("ExportStaticContents Completed");
            return File(fileDto.Data, fileDto.ContentType, fileDto.StaticContentExportFileName);
        }

        [HttpGet("{id}", Name = "GetStaticContentById")]
        public async Task<ActionResult> GetStaticContentById(Guid id)
        {
            _logger.LogInformation("GetStaticContentById Initiated");
            var getStaticContentDetailQuery = new GetStaticContentDetailQuery() { ID = id };
            _logger.LogInformation("GetStaticContentById Initiated");
            return Ok(await _mediator.Send(getStaticContentDetailQuery));
        }
    }
}
