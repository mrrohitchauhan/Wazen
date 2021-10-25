import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerService } from '../../../services/customer.service';
import { CustomerListComponent } from './customer-list.component';

export const CustomerListRoutes: Routes = [
  { path: '', component: CustomerListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(CustomerListRoutes)],
  declarations: [CustomerListComponent],
  providers: [CustomerService]
})
export class CustomerListModule {
}
