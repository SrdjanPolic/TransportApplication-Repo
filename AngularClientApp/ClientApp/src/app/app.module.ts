import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EmployeesComponent } from './employees/employees.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { CounterComponent } from './counter/counter.component';
import { NavMenu2Component } from './nav-menu2/nav-menu2.component';

import {MaterialModule} from './material/material.module';
import {ReactiveFormsModule, FormsModule} from '@angular/forms';
import {AngularFireModule} from '@angular/fire';
import {AngularFireDatabaseModule} from '@angular/fire/database';

import { AppRoutingModule } from './app-routing.module';
import { CustomersComponent } from './customers/customers.component';
import {CustomerService} from './shared/customer.service';
import { CustomerComponent } from './customers/customer/customer.component';
import {environment} from '../environments/environment';
import { CustomerListComponent } from './customers/customer-list/customer-list.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavMenu2Component,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CustomersComponent,
    CustomerComponent,
    CustomerListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,

    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    AngularFireModule.initializeApp(environment.firebaseConfig),
    AngularFireDatabaseModule,

    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      {path: 'customers', component: CustomersComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [CustomerComponent]
})
export class AppModule { }
