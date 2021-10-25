import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ComponentsModule } from '../../components/components.module';
import { HttpConfigInterceptor } from '../../interceptors/http-request.interceptor';
import { RoleService } from '../../services/role.service';
import { MainLayoutRoutes } from './main-layout.routing';

@NgModule({
  imports: [CommonModule, RouterModule.forChild(MainLayoutRoutes), HttpClientModule],
  declarations: [],
  exports: [],
  providers: [RoleService, {
    provide: HTTP_INTERCEPTORS,
    useClass: HttpConfigInterceptor,
    multi: true,
  },]
})
export class MainLayoutModule { }
