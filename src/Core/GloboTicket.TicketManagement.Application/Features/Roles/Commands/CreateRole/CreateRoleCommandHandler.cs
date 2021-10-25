﻿using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.Application.Features.Roles.Commands.CreateRole
{
   public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Response<CreateRoleDto>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public CreateRoleCommandHandler(IMapper mapper, IRoleRepository roleRepository)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<Response<CreateRoleDto>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var createRoleCommandResponse = new Response<CreateRoleDto>();

            var validator = new CreateRoleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createRoleCommandResponse.Succeeded = false;
                createRoleCommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createRoleCommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var role = new Role() { RoleName = request.RoleName,
                    RoleArabicName = request.RoleArabicName,
                    Description = request.Description,
                    IsActive = request.IsActive,
                };
                role = await _roleRepository.AddAsync(role);
                createRoleCommandResponse.Data = _mapper.Map<CreateRoleDto>(role);
                createRoleCommandResponse.Succeeded = true;
                createRoleCommandResponse.Message = "success";
            }

            return createRoleCommandResponse;
        }

    
    }
}
