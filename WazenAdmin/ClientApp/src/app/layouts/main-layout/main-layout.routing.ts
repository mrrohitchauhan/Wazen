import { Routes } from "@angular/router";

export const MainLayoutRoutes: Routes = [
  {
    path: "dashboard",
    loadChildren: () =>
      import("../../pages/dashboard/dashboard.module").then(
        (m) => m.DashboardModule
      ),
  },
  {
    path: "add-staticcontent",
    loadChildren: () =>
      import(
        "../../pages/staticcontent/add-staticcontent/add-staticcontent.module"
      ).then((m) => m.AddStaticContentModule),
  },
  {
    path: "add-staticcontent/:staticContentId",
    loadChildren: () =>
      import(
        "../../pages/staticcontent/add-staticcontent/add-staticcontent.module"
      ).then((m) => m.AddStaticContentModule),
  },
  {
    path: "staticcontent-list",
    loadChildren: () =>
      import(
        "../../pages/staticcontent/staticcontent-list/staticcontent-list.module"
      ).then((m) => m.StaticContentListModule),
  },
  {
    path: "add-homepagebanner",
    loadChildren: () =>
      import(
        "../../pages/homepagebanner/add-homepagebanner/add-homepagebanner.module"
      ).then((m) => m.AddHomePageBannerModule),
  },
  {
    path: "add-homepagebanner/:homePageBannerId",
    loadChildren: () =>
      import(
        "../../pages/homepagebanner/add-homepagebanner/add-homepagebanner.module"
      ).then((m) => m.AddHomePageBannerModule),
  },
  {
    path: "homepagebanner-list",
    loadChildren: () =>
      import(
        "../../pages/homepagebanner/homepagebanner-list/homepagebanner-list.module"
      ).then((m) => m.HomePageBannerListModule),
  },
  {
    path: "add-user",
    loadChildren: () =>
      import("../../pages/users/add-user/add-user.module").then(
        (m) => m.AddUserModule
      ),
  },
  {
    path: "users",
    loadChildren: () =>
      import("../../pages/users/user-list/user-list.module").then(
        (m) => m.UserListModule
      ),
  },
  {
    path: "add-user/:Id",
    loadChildren: () =>
      import("../../pages/users/add-user/add-user.module").then(
        (m) => m.AddUserModule
      ),
  },
  {
    path: "customer",
    loadChildren: () =>
      import("../../pages/customer/customer-list/customer-list.module").then(
        (m) => m.CustomerListModule
      ),
  },
  {
    path: "add-customer",
    loadChildren: () =>
      import("../../pages/customer/add-customer/add-customer.module").then(
        (m) => m.AddCustomerModule
      ),
  },

  {
    path: "add-customer/:customerId",
    loadChildren: () =>
      import("../../pages/customer/add-customer/add-customer.module").then(
        (m) => m.AddCustomerModule
      ),
  },
{
  path: "insurancecompanies",
    loadChildren: () =>
      import(
        "../../pages/InsuranceCompanies/insurancecompanies-list/insurancecompanies-list.module"
      ).then((m) => m.InsurancecompaniesListModule),
  },
{
  path: "add-insurancecompanies",
    loadChildren: () =>
      import(
        "../../pages/InsuranceCompanies/add-insurancecompanies/add-insurancecompanies.module"
      ).then((m) => m.AddInsuranceCompaniesModule),
  },

{
  path: "add-insurancecompanies/:icid",
    loadChildren: () =>
      import(
        "../../pages/InsuranceCompanies/add-insurancecompanies/add-insurancecompanies.module"
      ).then((m) => m.AddInsuranceCompaniesModule),
  },
  {
    path: "add-role",
    loadChildren: () =>
      import("../../pages/roles/add-role/add-role.module").then(
        (m) => m.AddRoleModule
      ),
  },
  {
    path: "add-role/:roleId",
    loadChildren: () =>
      import("../../pages/roles/add-role/add-role.module").then(
        (m) => m.AddRoleModule
      ),
  },
  {
    path: "roles",
    loadChildren: () =>
      import("../../pages/roles/role-list/role-list.module").then(
        (m) => m.RoleListModule
      ),
  },
  { path: "", redirectTo: "dashboard", pathMatch: "full" },
];
