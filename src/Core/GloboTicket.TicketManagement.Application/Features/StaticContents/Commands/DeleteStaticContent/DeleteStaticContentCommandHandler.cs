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

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.DeleteStaticContent
{
    public class DeleteStaticContentCommandHandler : IRequestHandler<DeleteStaticContentCommand>
    {
        private readonly IStaticContentRepository _staticContentRepository;
        private readonly IDataProtector _protector;

        public DeleteStaticContentCommandHandler(IStaticContentRepository staticContentRepository, IDataProtectionProvider provider)
        {
            _staticContentRepository = staticContentRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Unit> Handle(DeleteStaticContentCommand request, CancellationToken cancellationToken)
        {
            //var staticContentId = new Guid(_protector.Unprotect(request.ID));
            //var staticContentToDelete = await _staticContentRepository.GetByIdAsync(staticContentId);
            var staticContentToDelete = await _staticContentRepository.GetByIdAsync(request.ID);
            if (staticContentToDelete == null)
            {
                //throw new NotFoundException(nameof(Event), request.ID);
                throw new NotFoundException(nameof(Event), request.ID);
            }

            await _staticContentRepository.DeleteAsync(staticContentToDelete);
            return Unit.Value;
        }
    }
}
