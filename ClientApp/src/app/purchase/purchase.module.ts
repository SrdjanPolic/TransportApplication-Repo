import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {InvoicesComponent} from './invoice-list/invoices.component';
import {PurchaseRoutingModule} from './purchase-routing/purchase-routing.module';
import {InvoiceComponent} from './invoice-modify/invoice.component';
import {InvoiceLinesComponent} from './invoice-lines/invoice-lines.component';
import {FormsModule} from '@angular/forms';
import {TransformbooleanPipe} from './../shared/transformboolean.pipe';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    PurchaseRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule
  ],
  declarations: [InvoicesComponent, InvoiceComponent, InvoiceLinesComponent,TransformbooleanPipe],
  entryComponents: [InvoiceLinesComponent],
  providers: [TransformbooleanPipe],
})
export class PurchaseModule { }
