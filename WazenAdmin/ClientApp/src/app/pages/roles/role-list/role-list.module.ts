import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RoleService } from '../../../services/role.service';
import { RoleListComponent } from './role-list.component';

export const RoleListRoutes: Routes = [
  { path: '', component: RoleListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(RoleListRoutes)],
  declarations: [RoleListComponent],
  providers: [RoleService]
})
export class RoleListModule {
}
