import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { UserService } from '../../../services/user.service';
import { AddUserComponent } from './add-user.component';

export const AddUserRoutes: Routes = [
  { path: '', component: AddUserComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddUserRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddUserComponent],
  providers: [UserService]
})
export class AddUserModule {
}
