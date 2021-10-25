using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, Response<UserDetailVm>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandler(IMapper mapper, IUserRepository userRepository, ILogger<GetUserDetailQueryHandler> logger)
        {
            _mapper = mapper;
            _userRepository = userRepository;

        }
        public async Task<Response<UserDetailVm>> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            var userDetailDto = _mapper.Map<UserDetailVm>(user);


            var response = new Response<UserDetailVm>(userDetailDto);

            return response;
        }


    }
}