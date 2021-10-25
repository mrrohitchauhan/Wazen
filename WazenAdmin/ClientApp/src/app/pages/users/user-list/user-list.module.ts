import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserService } from '../../../services/user.service';
import { UserComponent } from './user-list.component';

export const UserListRoutes: Routes = [
  { path: '', component: UserComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(UserListRoutes)],
  declarations: [UserComponent],
  providers: [UserService]
})
export class UserListModule {
}
