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
using Microsoft.Extensions.Logging;

namespace GloboTicket.TicketManagement.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepsitory;
        //  private readonly IDataProtector _protector;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public DeleteUserCommandHandler( IUserRepository userRepsitory, IDataProtectionProvider provider)
        {
            _userRepsitory = userRepsitory;
           
            //_protector = provider.CreateProtector("");
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            // var studentId = new Guid(request.StudentId);
            var userToDelete = await _userRepsitory.GetByIdAsync(request.Id);

            if (userToDelete == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            await _userRepsitory.DeleteAsync(userToDelete);
            return Unit.Value;
        }
    }
}
