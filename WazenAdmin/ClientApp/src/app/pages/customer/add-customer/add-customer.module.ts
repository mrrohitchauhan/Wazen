import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { CustomerService } from '../../../services/customer.service';
import { AddCustomerComponent } from './add-customer.component';


export const AddCustomerRoutes: Routes = [
  { path: '', component: AddCustomerComponent },
  { path: '/:roleId', component: AddCustomerComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddCustomerRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddCustomerComponent],
  providers: [CustomerService],
})
export class AddCustomerModule {
}
