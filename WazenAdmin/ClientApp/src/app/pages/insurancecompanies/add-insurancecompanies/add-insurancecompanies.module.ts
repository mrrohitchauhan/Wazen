import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { InsuranceCompaniesService } from '../../../services/InsuranceCompanies.service';
import { AddInsuranceCompaniesComponent } from './add-insurancecompanies.component';


export const AddInsuranceCompaniesServiceRoutes: Routes = [
  { path: '', component: AddInsuranceCompaniesComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddInsuranceCompaniesServiceRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddInsuranceCompaniesComponent],
  providers: [InsuranceCompaniesService],
})
export class AddInsuranceCompaniesModule {
}


