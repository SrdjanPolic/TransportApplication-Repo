import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomerRoutingModule } from './customer-routing/customer-routing.module';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDataComponent } from './customer-details/customer-data/customer-data.component';
import { AccountDataComponent } from './customer-details/account-data/account-data.component';
import { CustomerCreateComponent } from './customer-create/customer-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { CustomerUpdateComponent } from './customer-update/customer-update.component';
import { CustomerDeleteComponent } from './customer-delete/customer-delete.component';
import {TransformModule} from './../shared/transform/transform.module';
import { MatTableExporterModule} from 'mat-table-exporter';

@NgModule({
  imports: [
    CommonModule,
    CustomerRoutingModule,
    ReactiveFormsModule,
    MatTableExporterModule,
    SharedModule,
    TransformModule
  ],
  declarations: [CustomerListComponent, CustomerDetailsComponent, CustomerDataComponent,
    AccountDataComponent, CustomerCreateComponent, CustomerUpdateComponent, CustomerDeleteComponent]
})
export class CustomerModule { }
