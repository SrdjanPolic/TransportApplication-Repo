import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import {InvoicesComponent} from './../invoice-list/invoices.component';
import {InvoiceComponent} from './../invoice-modify/invoice.component';
import {InvoiceLinesComponent} from './../invoice-lines/invoice-lines.component';
import { InvoicePrintComponent } from '../invoice-print/invoice-print.component';
import { InvoiceInoPrintComponent } from '../invoice-ino-print/invoice-ino-print.component';
import { InvoiceRefundPrintComponent } from '../invoice-refund-print/invoice-refund-print.component';

const routes: Routes = [
  { path: 'SalesInvoices', component: InvoicesComponent },
  { path: 'details/:id', component: InvoiceComponent },
  { path: 'create', component: InvoiceComponent },
  { path: 'update/:id', component: InvoiceComponent },
  { path: 'delete/:id', component: InvoiceComponent },
  { path: 'details/:id/print', component: InvoicePrintComponent},
  { path: 'details/:id/inoprint', component: InvoiceInoPrintComponent},
  { path: 'details/:id/inorefundprint', component: InvoiceRefundPrintComponent}
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
