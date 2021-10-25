import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { RouterModule } from '@angular/router';
import { ComponentsModule } from './components/components.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent,
    //AuthLayoutComponent
  ],
  imports: [
    RouterModule,
    HttpClientModule,
    AppRoutingModule,
    ComponentsModule,
    NgbModule,
  ],
  providers: [ ],
  bootstrap: [AppComponent]
})
export class AppModule { }
