using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Responses;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Response<CreateUserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<Response<CreateUserDto>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createUserCommandResponse = new Response<CreateUserDto>();

            var validator = new CreateUserCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createUserCommandResponse.Succeeded = false;
                createUserCommandResponse.Errors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createUserCommandResponse.Errors.Add(error.ErrorMessage);
                }
            }
            else
            {
                var user = new User() { Name = request.Name, 
                    Username = request.Username, 
                    Email = request.Email, 
                    Password = request.Password,
                    ContactNo = request.ContactNo,
                    Designation = request.Designation,
                    Date = request.Date,
                    IsActive = request.IsActive,
                    CreatedBy = request.CreatedBy,
                    ModifiedBy = request.ModifiedBy,
                    CreatedOn = request.CreatedOn,
                    ModifiedOn = request.ModifiedOn
                    };
                user = await _userRepository.AddAsync(user);
                createUserCommandResponse.Data = _mapper.Map<CreateUserDto>(user);
                createUserCommandResponse.Succeeded = true;
                createUserCommandResponse.Message = "success";
            }

            return createUserCommandResponse;
        }
    }
}
