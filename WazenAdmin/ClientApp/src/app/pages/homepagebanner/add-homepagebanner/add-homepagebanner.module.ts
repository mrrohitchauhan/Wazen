import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { HomePageBannerService } from '../../../services/homepagebanner.service';
import { AddHomePageBannerComponent } from './add-homepagebanner.component';

export const AddHomePageBannerRoutes: Routes = [
  { path: '', component: AddHomePageBannerComponent },
  { path: '/:homePageBannerId', component: AddHomePageBannerComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddHomePageBannerRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddHomePageBannerComponent],
  providers: [HomePageBannerService]
})
export class AddHomePageBannerModule {
}
