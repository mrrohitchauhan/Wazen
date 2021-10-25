import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StaticContentService } from '../../../services/staticcontent.service';
import { StaticContentListComponent } from './staticcontent-list.component';

export const StaticContentListRoutes: Routes = [
  { path: '', component: StaticContentListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(StaticContentListRoutes)],
  declarations: [StaticContentListComponent],
  providers: [StaticContentService]
})
export class StaticContentListModule {
}
