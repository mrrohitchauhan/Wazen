using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentDetail
{
    public class GetStaticContentDetailQueryHandler : IRequestHandler<GetStaticContentDetailQuery, Response<StaticContentDetailVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<StaticContent> _staticContentRepository;
        private readonly IMapper _mapper;

        private readonly IDataProtector _protector;
        public GetStaticContentDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<StaticContent> staticContentRepository, IDataProtectionProvider provider)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _staticContentRepository = staticContentRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Response<StaticContentDetailVm>> Handle(GetStaticContentDetailQuery request, CancellationToken cancellationToken)
        {
            //string id = _protector.Unprotect(request.ID);

            //var staticContent = await _eventRepository.GetByIdAsync(new Guid(id));
            var staticContent = await _staticContentRepository.GetByIdAsync(request.ID);

            var staticContentDetailDto = _mapper.Map<StaticContentDetailVm>(staticContent);

            /*var staticContent = await _staticContentRepository.GetByIdAsync(@event.ID);

            if (staticContent == null)
            {
                throw new NotFoundException(nameof(Event), request.ID);
            }
            eventDetailDto.Student = _mapper.Map<StaticContentDto>(staticContent);
            */
            var response = new Response<StaticContentDetailVm>(staticContentDetailDto);
            return response;
        }
    }
}
