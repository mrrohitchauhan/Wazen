import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpConfigInterceptor } from '../../interceptors/http-request.interceptor';
import { MainLayoutRoutes } from './main-layout.routing';
import { ChartsModule } from "ng2-charts";

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(MainLayoutRoutes),
    HttpClientModule,
    ChartsModule,
    NgbModule,
    ReactiveFormsModule,],
  declarations: [],
  exports: [],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: HttpConfigInterceptor,
    multi: true,
  },]
})
export class MainLayoutModule { }
