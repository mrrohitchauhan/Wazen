using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.Application.Features.Roles.Commands.DeleteRole
{
     public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
    {
        private readonly IRoleRepository _roleRepsitory;
        //  private readonly IDataProtector _protector;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public DeleteRoleCommandHandler(IRoleRepository roleRepsitory, IDataProtectionProvider provider)
        {
            _roleRepsitory = roleRepsitory;

            //_protector = provider.CreateProtector("");
        }
        

        public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            // var studentId = new Guid(request.StudentId);
            var roleToDelete = await _roleRepsitory.GetByIdAsync(request.Id);

            if (roleToDelete == null)
            {
                throw new NotFoundException(nameof(Role), request.Id);
            }

            await _roleRepsitory.DeleteAsync(roleToDelete);
            return Unit.Value;
        }
    }
}
