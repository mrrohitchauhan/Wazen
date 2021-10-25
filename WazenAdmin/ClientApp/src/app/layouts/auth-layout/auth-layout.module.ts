import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule, Routes } from "@angular/router";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

const AuthenticationRoutes: Routes = [
  //{ path: "signin", component: SigninComponent },
  //{
  //  path: "signup",
  //  component: SignupComponent,
  //},
  {
    path: "",
    redirectTo: "signin",
    pathMatch: "full",
  },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(AuthenticationRoutes),
    ReactiveFormsModule,
    FormsModule,
  ],
})
export class AuthLayoutModule {
}
