import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import {InvoicesComponent} from './../invoice-list/invoices.component';
import {InvoiceComponent} from './../invoice-modify/invoice.component';
import {InvoiceLinesComponent} from './../invoice-lines/invoice-lines.component';
import {PrintLayoutComponent} from './../../print-layout/print-layout.component';

const routes: Routes = [
  { path: 'SalesInvoices', component: InvoicesComponent },
  { path: 'details/:id', component: InvoiceComponent },
  { path: 'create', component: InvoiceComponent },
  { path: 'update/:id', component: InvoiceComponent },
  { path: 'delete/:id', component: InvoiceComponent },
  { path: 'print' , component: PrintLayoutComponent }
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
export class SalesRoutingModule { }
