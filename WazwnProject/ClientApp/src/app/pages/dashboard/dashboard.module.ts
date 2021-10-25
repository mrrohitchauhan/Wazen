import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardService } from '../../services/dashboard.service';
import { DashboardComponent } from './dashboard.component';

export const routes: Routes = [
  { path: '', component: DashboardComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(routes), HttpClientModule],
  declarations: [DashboardComponent],
  exports: [],
  providers: [DashboardService]
})
export class DashboardModule {
}
