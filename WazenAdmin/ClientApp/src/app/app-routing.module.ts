import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { AutoLoginGuard } from './guards/auto-login.guard';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';

const routes: Routes = [
  //{
  //  path: 'authentication',
  //  loadChildren: () => import('./pages/authentication/authentication.module').then(module => module.AuthenticationModule),
  //  component: SigninPageComponent,
  //  canLoad: [AutoLoginGuard],
  //},
 
  {
    path: 'wazen',
    component: MainLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: () =>
          import("./layouts/main-layout/main-layout.module").then(
            (m) => m.MainLayoutModule
          ),
        //canLoad: [AuthGuard],
      },
    ],
  },
  {
    path: "authentication",
    component: AuthLayoutComponent,
    children: [
      {
        path: "",
        loadChildren: () =>
          import("./layouts/auth-layout/auth-layout.module").then(
            (m) => m.AuthLayoutModule
          ),
        //canLoad: [AutoLoginGuard],
      },
    ],
  },
  {
    path: "",
    redirectTo: "wazen",
    pathMatch: "full",
  },

];

@NgModule({
  imports: [CommonModule, BrowserModule, RouterModule.forRoot(routes)],
})
export class AppRoutingModule { }
