import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InvoicesComponent} from './invoice-list/invoices.component';
import { PurchaseRoutingModule} from './purchase-routing/purchase-routing.module';
import { InvoiceComponent} from './invoice-modify/invoice.component';
import { InvoiceLinesComponent} from './invoice-lines/invoice-lines.component';
import { FormsModule} from '@angular/forms';
import { TransformModule} from './../shared/transform/transform.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { MatTableExporterModule} from 'mat-table-exporter';

@NgModule({
  imports: [
    CommonModule,
    PurchaseRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    TransformModule,
    MatTableExporterModule
  ],
  declarations: [InvoicesComponent, InvoiceComponent, InvoiceLinesComponent],
  entryComponents: [InvoiceLinesComponent],
  providers: [],
})
export class PurchaseModule { }
