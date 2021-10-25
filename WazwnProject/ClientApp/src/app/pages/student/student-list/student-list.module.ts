import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentListComponent } from './student-list.component';

export const StudentListRoutes: Routes = [
  { path: '', component: StudentListComponent },
];

@NgModule({
  imports: [CommonModule, RouterModule.forChild(StudentListRoutes)],
  declarations: [StudentListComponent]
})
export class StudentListModule {
}
