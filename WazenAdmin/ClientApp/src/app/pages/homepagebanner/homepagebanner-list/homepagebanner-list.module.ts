import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageBannerService } from '../../../services/homepagebanner.service';
import { HomePageBannerListComponent } from './homepagebanner-list.component';

export const HomePageBannerListRoutes: Routes = [
  { path: '', component: HomePageBannerListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(HomePageBannerListRoutes)],
  declarations: [HomePageBannerListComponent],
  providers: [HomePageBannerService]
})
export class HomePageBannerListModule {
}
