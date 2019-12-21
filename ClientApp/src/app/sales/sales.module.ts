import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {InvoicesComponent} from './invoice-list/invoices.component';
import {SalesRoutingModule} from './sales-routing/sales-routing.module';
import {InvoiceComponent} from './invoice-modify/invoice.component';
import {InvoiceLinesComponent} from './invoice-lines/invoice-lines.component';
import {FormsModule} from '@angular/forms';
import {TransformModule} from './../shared/transform/transform.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { InvoicePrintComponent } from './invoice-print/invoice-print.component';


@NgModule({
  imports: [
    CommonModule,
    SalesRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    TransformModule
  ],
  declarations: [InvoicesComponent, InvoiceComponent, InvoiceLinesComponent,InvoicePrintComponent],
  entryComponents: [InvoiceLinesComponent],
  providers: []
})
export class SalesModule { }
