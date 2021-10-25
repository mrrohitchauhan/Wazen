using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.UpdateStaticContent
{
    public class UpdateStaticContentCommandHandler : IRequestHandler<UpdateStaticContentCommand, Response<Guid>>
    {
        private readonly IStaticContentRepository _staticContentRepository;
        private readonly IMapper _mapper;

        public UpdateStaticContentCommandHandler(IMapper mapper, IStaticContentRepository staticContentRepository)
        {
            _mapper = mapper;
            _staticContentRepository = staticContentRepository;
        }

        public async Task<Response<Guid>> Handle(UpdateStaticContentCommand request, CancellationToken cancellationToken)
        {
            //var staticContentId = new Guid(_protector.Unprotect(request.ID));
            //var staticContentToUpdate = await _staticContentRepository.GetByIdAsync(staticContentId);
            var staticContentToUpdate = await _staticContentRepository.GetByIdAsync(request.ID);

            if (staticContentToUpdate == null)
            {
                //throw new NotFoundException(nameof(StaicContent), staticContentId);
                throw new NotFoundException(nameof(StaticContent), request.ID);
            }

            var validator = new UpdateStaticContentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, staticContentToUpdate, typeof(UpdateStaticContentCommand), typeof(StaticContent));

            await _staticContentRepository.UpdateAsync(staticContentToUpdate);

            return new Response<Guid>(request.ID, "Updated successfully ");
        }
    }
}
