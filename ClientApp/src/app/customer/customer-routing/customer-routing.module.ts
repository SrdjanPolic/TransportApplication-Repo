import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { CustomerListComponent } from '../customer-list/customer-list.component';
import { CustomerDetailsComponent } from '../customer-details/customer-details.component';
import { CustomerCreateComponent } from '../customer-create/customer-create.component';
import { CustomerUpdateComponent } from '../customer-update/customer-update.component';
import { CustomerDeleteComponent } from 'src/app/customer/customer-delete/customer-delete.component';

const routes: Routes = [
  { path: 'customers', component: CustomerListComponent },
  { path: 'details/:id', component: CustomerDetailsComponent },
  { path: 'create', component: CustomerCreateComponent },
  { path: 'update/:id', component: CustomerUpdateComponent },
  { path: 'delete/:id', component: CustomerDeleteComponent }
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class CustomerRoutingModule { }
