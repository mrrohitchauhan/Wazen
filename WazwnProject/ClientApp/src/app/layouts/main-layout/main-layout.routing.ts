import { Routes } from "@angular/router";


export const MainLayoutRoutes: Routes = [
  { path: "", redirectTo: "dashboard", pathMatch: "full" },
  {
    path: "dashboard",
    loadChildren: () =>
      import("../../pages/dashboard/dashboard.module").then(
        (m) => m.DashboardModule
      ),
  },
  {
    path: "add-role", loadChildren: () =>
      import("../../pages/roles/add-role/add-role.module").then(
        (m) => m.AddRoleModule
      ),
  },
  {
    path: "roles", loadChildren: () =>
      import("../../pages/roles/role-list/role-list.module").then(
        (m) => m.RoleListModule
      ),
  },
  {
    path: "student", loadChildren: () =>
      import("../../pages/student/student-list/student-list.module").then(
        (m) => m.StudentListModule
      ),
  },
];
