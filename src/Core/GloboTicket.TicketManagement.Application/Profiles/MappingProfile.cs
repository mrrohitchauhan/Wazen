using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.StoredProcedure;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.Transaction;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Commands.CreateHomePageBanner;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannerDetail;
using GloboTicket.TicketManagement.Application.Features.HomePageBanners.Queries.GetHomePageBannersList;
using GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Commands.CreateStaticContent;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentDetail;
using GloboTicket.TicketManagement.Application.Features.StaticContents.Queries.GetStaticContentsList;
using GloboTicket.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Features.HomePageBanners.Commands.CreateHomePageBanner;
using GloboTicket.TicketManagement.Application.Features.Users.Commands.UpdateUser;
using GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUserDetail;
using GloboTicket.TicketManagement.Application.Features.Users.Commands.CreateUser;
using GloboTicket.TicketManagement.Application.Features.Users.Queries.GetUsersList;
using GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomersList;
using GloboTicket.TicketManagement.Application.Features.Customers.Queries.GetCustomerDetail;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands.UpdateCustomer;
using GloboTicket.TicketManagement.Application.Features.Customers.Commands.CreateCustomer;
using GloboTicket.Application.Features.Roles.Commands.CreateRole;
using GloboTicket.Application.Features.Roles.Commands.UpdateRole;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRoleDetail;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.UpdateInsuranceCompanies;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesDetail;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Commands.CreateInsuranceCompanies;
using GloboTicket.TicketManagement.Application.Features.InsuranceCompanies.Queries.GetInsuranceCompaniesList;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<StaticContent, StaticContentDto>();
            CreateMap<StaticContent, StaticContentListVm>();
            CreateMap<StaticContent, CreateStaticContentCommand>();
            CreateMap<StaticContent, CreateStaticContentDto>();
            CreateMap<StaticContent, StaticContentDetailVm>();

            CreateMap<HomePageBanner, HomePageBannerDto>();
            CreateMap<HomePageBanner, HomePageBannerListVm>();
            CreateMap<HomePageBanner, CreateHomePageBannerCommand>();
            CreateMap<HomePageBanner, CreateHomePageBannerDto>();
            CreateMap<HomePageBanner, HomePageBannerDetailVm>();

            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, CreateUserDto>();
            CreateMap<User, UserListVm>();
            CreateMap<User, CreateUserCommand>();
            CreateMap<User, UserDetailVm>();

            CreateMap<Customer, CustomerListVm>();
            CreateMap<Customer, CustomerDetailVm>();
            CreateMap<Customer, CreateCustomerCommand>();
            CreateMap<Customer, CreateCustomerDto>();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();

            CreateMap<Role, UpdateRoleCommand>().ReverseMap();
            CreateMap<Role, CreateRoleDto>();
            CreateMap<Role, RoleListVm>();
            CreateMap<Role, CreateRoleCommand>();
            CreateMap<Role, RoleDetailVm>();

            CreateMap<InsuranceCompanies, UpdateInsuranceCompaniesCommand>().ReverseMap();
            CreateMap<InsuranceCompanies, CreateInsuranceCompaniesDto>();
            CreateMap<InsuranceCompanies, InsuranceCompaniesDetailVm>();
            CreateMap<InsuranceCompanies, InsuranceCompaniesListVm>();
            CreateMap<InsuranceCompanies, CreateInsuranceCompaniesCommand>();

            CreateMap<StaticContent, StaticContentListVm>().ConvertUsing<StaticContentVmCustomMapper>();
            CreateMap<HomePageBanner, HomePageBannerListVm>().ConvertUsing<HomePageBannerVmCustomMapper>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();


        }
    }
}
