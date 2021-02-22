import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InvoicesComponent} from './invoice-list/invoices.component';
import { SalesRoutingModule} from './sales-routing/sales-routing.module';
import { InvoiceComponent} from './invoice-modify/invoice.component';
import { InvoiceLinesComponent} from './invoice-lines/invoice-lines.component';
import { FormsModule} from '@angular/forms';
import { TransformModule} from './../shared/transform/transform.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { InvoicePrintComponent } from './invoice-print/invoice-print.component';
import { InvoiceInoPrintComponent} from './invoice-ino-print/invoice-ino-print.component';
import { InvoiceRefundPrintComponent} from './invoice-refund-print/invoice-refund-print.component';
import { InvoiceATPrintComponent} from './invoice-at-print/invoice-at-print.component';
import { MatTableExporterModule} from 'mat-table-exporter';


@NgModule({
  imports: [
    CommonModule,
    SalesRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    MatTableExporterModule,
    TransformModule
  ],
  declarations: [InvoicesComponent, InvoiceComponent, InvoiceLinesComponent, InvoicePrintComponent,
    InvoiceInoPrintComponent, InvoiceRefundPrintComponent,InvoiceATPrintComponent],
  entryComponents: [InvoiceLinesComponent],
  providers: []
})
export class SalesModule { }
