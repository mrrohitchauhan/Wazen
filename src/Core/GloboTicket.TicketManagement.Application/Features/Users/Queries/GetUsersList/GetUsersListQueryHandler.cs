using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUsersList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, Response<IEnumerable<UserListVm>>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public GetUsersListQueryHandler(IMapper mapper, IUserRepository userRepository, ILogger<GetUsersListQueryHandler> logger)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<Response<IEnumerable<UserListVm>>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allUsers = (await _userRepository.ListAllAsync()).OrderBy(x => x.Name);
            var user = _mapper.Map<IEnumerable<UserListVm>>(allUsers);
            _logger.LogInformation("Hanlde Completed");
            return new Response<IEnumerable<UserListVm>>(user, "success");
        }

    }



}
