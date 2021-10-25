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
using Microsoft.AspNetCore.DataProtection;

namespace GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesDetail
{

    public class GetInsuranceCompaniesDetailQueryHandler : IRequestHandler<GetInsuranceCompaniesDetailQuery, Response<InsuranceCompaniesDetailVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies> _insuranceCompaniesRepository;
        private readonly IMapper _mapper;

        private readonly IDataProtector _protector;
        public GetInsuranceCompaniesDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<GloboTicket.TicketManagement.Domain.Entities.InsuranceCompanies> insuranceCompaniesRepository, IDataProtectionProvider provider)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _insuranceCompaniesRepository = insuranceCompaniesRepository;
            _protector = provider.CreateProtector("");
        }

        public async Task<Response<InsuranceCompaniesDetailVm>> Handle(GetInsuranceCompaniesDetailQuery request, CancellationToken cancellationToken)
        {
            var insuranceCompanies = await _insuranceCompaniesRepository.GetByIdAsync(request.ICID);

            var insuranceCompaniesDetailDto = _mapper.Map<InsuranceCompaniesDetailVm>(insuranceCompanies);


            var response = new Response<InsuranceCompaniesDetailVm>(insuranceCompaniesDetailDto);
            return response;
        }
    }
   
}
