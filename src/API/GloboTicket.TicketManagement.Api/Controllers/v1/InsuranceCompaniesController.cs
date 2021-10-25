using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.CreateInsuranceCompanies;
using Microsoft.AspNetCore.Http;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesDetail;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.UpdateInsuranceCompanies;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.DeleteInsuranceCompanies;
using System;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesList;

namespace GloboTicket.TicketManagement.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class InsuranceCompaniesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public InsuranceCompaniesController(IMediator mediator, ILogger<InsuranceCompaniesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("all", Name = "GetAllInsuranceCompanies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllStudents()
        {
            _logger.LogInformation("GetAll Insurance Companies Initiated");
            var dtos = await _mediator.Send(new GetInsuranceCompaniesListQuery());
            _logger.LogInformation("GetAll Insurance Companies Completed");
            return Ok(dtos);
        }


        [HttpPost(Name = "AddInsuranceCompanies")]
        public async Task<ActionResult> Create([FromBody] CreateInsuranceCompaniesCommand createInsuranceCompaniesCommand)
        {
            _logger.LogInformation("Add Insurance Companies Initiated");
            var response = await _mediator.Send(createInsuranceCompaniesCommand);
            _logger.LogInformation("Add Insurance Companies Completed");
            return Ok(response);
        }

        [HttpPut(Name = "UpdateInsuranceCompanies")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateInsuranceCompaniesCommand updateInsuranceCompaniesCommand)
        {
            _logger.LogInformation("Update Insurance Companies Initiated");
            var response = await _mediator.Send(updateInsuranceCompaniesCommand);
            _logger.LogInformation("Update Insurance Companies Completed");
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteInsuranceCompanies")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var deleteStudentCommand = new DeleteInsuranceCompaniesCommand() { ICID = System.Guid.Parse(id) };
            _logger.LogInformation("Delete Insurance Companies Initiated");
            await _mediator.Send(deleteStudentCommand);
            _logger.LogInformation("Delete Insurance Companies Completed");
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetInsuranceCompaniesById")]
        public async Task<ActionResult> GetInsuranceCompaniesById(Guid id)
        {
            _logger.LogInformation("GetInsuranceCompaniesById Initiated");
            var getInsuranceCompaniesDetailQuery = new GetInsuranceCompaniesDetailQuery() { ICID = id };
            _logger.LogInformation("GetInsuranceCompaniesById Initiated");
            return Ok(await _mediator.Send(getInsuranceCompaniesDetailQuery));
        }
    }
}
