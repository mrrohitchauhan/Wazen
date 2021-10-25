using GloboTicket.TicketManagement.Api.Utility;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.DeleteHomePageBanner;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.UpdateHomePageBanner;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannerDetail;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersExport;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersList;
using GloboTicket.TicketManagement.Features.HomePageBanners.Commands.CreateHomePageBanner;
using MediatR;
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
    public class HomePageBannerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public HomePageBannerController(IMediator mediator, ILogger<HomePageBannerController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        //[Authorize]
        [HttpGet("all", Name = "GetAllHomePageBanners")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllHomePageBanners()
        {
            _logger.LogInformation("GetAllHomePageBanners Initiated");
            var dtos = await _mediator.Send(new GetHomePageBannersListQuery());
            _logger.LogInformation("GetAllHomePageBanners Completed");
            return Ok(dtos);
        }

        [HttpPost(Name = "AddHomePageBanner")]
        public async Task<ActionResult> Create([FromBody] CreateHomePageBannerCommand createHomePageBannerCommand)
        {
            _logger.LogInformation("AddHomePageBanner Initiated");
            var response = await _mediator.Send(createHomePageBannerCommand);
            _logger.LogInformation("AddHomePageBanner Completed");
            return Ok(response);
        }

        [HttpPut(Name = "UpdateHomePageBanner")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateHomePageBannerCommand updateHomePageBannerCommand)
        {
            _logger.LogInformation("UpdateHomePageBanner Initiated");
            var response = await _mediator.Send(updateHomePageBannerCommand);
            _logger.LogInformation("UpdateHomePageBanner Completed");
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "DeleteHomePageBanner")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var deleteHomePageBannerCommand = new DeleteHomePageBannerCommand() { ID = /*id*/System.Guid.Parse(id) };
            _logger.LogInformation("DeleteHomePageBanner Initiated");
            await _mediator.Send(deleteHomePageBannerCommand);
            _logger.LogInformation("DeleteHomePageBanner Completed");
            return NoContent();
        }

        [HttpGet("export", Name = "ExportHomePageBanners")]
        [FileResultContentType("text/csv")]
        public async Task<FileResult> ExportHomePageBanners()
        {
            _logger.LogInformation("ExportHomePageBanners Initiated");
            var fileDto = await _mediator.Send(new GetHomePageBannersExportQuery());
            _logger.LogInformation("ExportHomePageBanners Completed");
            return File(fileDto.Data, fileDto.ContentType, fileDto.HomePageBannerExportFileName);
        }

        [HttpGet("{id}", Name = "GetHomePageBannerById")]
        public async Task<ActionResult> GetStaticContentById(Guid id)
        {
            _logger.LogInformation("GetHomePageBannerById Initiated");
            var getHomePageBannerDetailQuery = new GetHomePageBannerDetailQuery() { ID = id };
            _logger.LogInformation("GetHomePageBannerById Initiated");
            return Ok(await _mediator.Send(getHomePageBannerDetailQuery));
        }
    }
}
