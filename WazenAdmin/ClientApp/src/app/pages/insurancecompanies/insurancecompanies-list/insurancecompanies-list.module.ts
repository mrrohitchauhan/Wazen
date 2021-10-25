import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InsuranceCompaniesService } from '../../../services/insurancecompanies.service';
import { InsuranceCompaniesListComponent } from './insurancecompanies-list.component';

export const InsuranceCompaniesListRoutes: Routes = [
  { path: '', component: InsuranceCompaniesListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(InsuranceCompaniesListRoutes)],
  declarations: [InsuranceCompaniesListComponent],
  providers: [InsuranceCompaniesService]
})
export class InsurancecompaniesListModule {
}



