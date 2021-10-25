import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { RoleService } from '../../../services/role.service';
import { AddRoleComponent } from './add-role.component';

export const AddRoleRoutes: Routes = [
  { path: '', component: AddRoleComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddRoleRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddRoleComponent],
  providers: [RoleService]
})
export class AddRoleModule {
}
