import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { StaticContentService } from '../../../services/staticcontent.service';
import { AddStaticContentComponent } from './add-staticcontent.component';

export const AddStaticContentRoutes: Routes = [
  { path: '', component: AddStaticContentComponent },
  { path: '/:staticContentId', component: AddStaticContentComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(AddStaticContentRoutes), ReactiveFormsModule, FormsModule],
  declarations: [AddStaticContentComponent],
  providers: [StaticContentService]
})
export class AddStaticContentModule {
}
