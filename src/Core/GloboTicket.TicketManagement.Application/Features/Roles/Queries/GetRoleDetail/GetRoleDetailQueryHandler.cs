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

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRoleDetail
{
   public  class GetRoleDetailQueryHandler : IRequestHandler<GetRoleDetailQuery , Response<RoleDetailVm>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        
        public GetRoleDetailQueryHandler(IMapper mapper, IRoleRepository roleRepository, ILogger<GetRoleDetailQueryHandler> logger)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
           
        }
        public async Task<Response<RoleDetailVm>> Handle(GetRoleDetailQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleRepository.GetByIdAsync(request.Id);

            var roleDetailDto = _mapper.Map<RoleDetailVm>(role);


            var response = new Response<RoleDetailVm>(roleDetailDto);

            return response;
        }


        }
    }
