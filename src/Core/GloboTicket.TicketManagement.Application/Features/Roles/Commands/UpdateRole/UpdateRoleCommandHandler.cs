using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.Application.Features.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, Response<Guid>>
    {
        private readonly IRoleRepository _roleRepsitory;
        private readonly IMapper _mapper;

        public UpdateRoleCommandHandler(IMapper mapper, IRoleRepository roleRepository)
        {
            _mapper = mapper;
            _roleRepsitory = roleRepository;
        }

        public async Task<Response<Guid>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {

            var roleToUpdate = await _roleRepsitory.GetByIdAsync(request.ID);

            if (roleToUpdate == null)
            {
                throw new NotFoundException(nameof(Role), request.ID);
            }

            var validator = new UpdateRoleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, roleToUpdate, typeof(UpdateRoleCommand), typeof(Role));

            await _roleRepsitory.UpdateAsync(roleToUpdate);

            return new Response<Guid>(request.ID, "Updated successfully ");

        }




    }
}
