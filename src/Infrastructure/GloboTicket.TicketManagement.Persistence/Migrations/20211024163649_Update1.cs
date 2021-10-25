using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Salutation = table.Column<string>(nullable: true),
                    EnglishFirstName = table.Column<string>(nullable: true),
                    EnglishMiddleName = table.Column<string>(nullable: true),
                    EnglishLastName = table.Column<string>(nullable: true),
                    ArabicFirstName = table.Column<string>(nullable: true),
                    ArabicMiddleName = table.Column<string>(nullable: true),
                    ArabicLastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NationalID = table.Column<string>(nullable: true),
                    IQAMA = table.Column<string>(nullable: true),
                    CompanyCR = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Occupation = table.Column<int>(nullable: false),
                    EducationID = table.Column<int>(nullable: false),
                    MaritalStatusID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    DriverID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomePageBanners",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true),
                    ProductID = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageBanners", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    ICID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    NameoftheIC = table.Column<string>(nullable: true),
                    NameofICAdmin = table.Column<string>(nullable: true),
                    ICAdminEmailAddress = table.Column<string>(nullable: true),
                    ICAdminPassword = table.Column<string>(nullable: true),
                    ICAdminPhoneNumber = table.Column<string>(nullable: true),
                    StartDateofCollaboration = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    OfficeNumber = table.Column<string>(nullable: true),
                    Agreements = table.Column<string>(nullable: true),
                    NoofPolicies = table.Column<string>(nullable: true),
                    ConfigurableParameters = table.Column<string>(nullable: true),
                    AdminExpenseForNAJM = table.Column<string>(nullable: true),
                    AdminExpenseForELM = table.Column<string>(nullable: true),
                    BankFees = table.Column<string>(nullable: true),
                    DefaultExpenses = table.Column<string>(nullable: true),
                    SharingPercentageForCancellation = table.Column<string>(nullable: true),
                    SharingPercentageForAdministrationFees = table.Column<string>(nullable: true),
                    CommissionAgreed = table.Column<string>(nullable: true),
                    APIAvailable = table.Column<string>(nullable: true),
                    EndpointURL = table.Column<string>(nullable: true),
                    RequestType = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    CancelAPIAvailable = table.Column<string>(nullable: true),
                    CancelEndpointURL = table.Column<string>(nullable: true),
                    CancelRequestType = table.Column<string>(nullable: true),
                    CancelHeader = table.Column<string>(nullable: true),
                    CancelBody = table.Column<string>(nullable: true),
                    RefundEndpointURL = table.Column<string>(nullable: true),
                    RefundRequestType = table.Column<string>(nullable: true),
                    RefundHeader = table.Column<string>(nullable: true),
                    RefundBody = table.Column<string>(nullable: true),
                    AddOnsRemoveEndpointURL = table.Column<string>(nullable: true),
                    AddOnsRemoveRequestType = table.Column<string>(nullable: true),
                    AddOnsRemoveHeader = table.Column<string>(nullable: true),
                    AddOnsRemoveBody = table.Column<string>(nullable: true),
                    AddOnsRemovePolicyPricing = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ICCreatedBy = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<double>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.ICID);
                });

            migrationBuilder.CreateTable(
                name: "StaticContents",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AboutUs = table.Column<string>(nullable: true),
                    TermsAndCondition = table.Column<string>(nullable: true),
                    PartnerName = table.Column<string>(nullable: true),
                    PartnerLogo = table.Column<string>(nullable: true),
                    RedirectedURL = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    NameOfTheCompany = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    SocialMediaIcon = table.Column<string>(nullable: true),
                    SocialMediaLink = table.Column<string>(nullable: true),
                    WebsiteLink = table.Column<string>(nullable: true),
                    GoogleLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticContents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2022, 8, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2022, 7, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2022, 2, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2022, 6, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2022, 2, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 4, 24, 22, 6, 48, 821, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 24, 22, 6, 48, 823, DateTimeKind.Local).AddTicks(4197));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "HomePageBanners");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "StaticContents");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2022, 8, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2022, 7, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2022, 2, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2022, 6, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2022, 2, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 4, 21, 11, 28, 55, 929, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 10, 21, 11, 28, 55, 930, DateTimeKind.Local).AddTicks(4260));
        }
    }
}
