import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule} from './reports-routing/reports-routing.module';
import { SalesInvoicesReportComponent} from './sales-invoices/sales-invoices.component';
import { PositionReportComponent} from './position-report/position-report.component';
import { TravelReportComponent} from './travel-report/travel-report.component';
import { FormsModule} from '@angular/forms';
import { TransformModule} from '../shared/transform/transform.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    TransformModule
  ],
  declarations: [SalesInvoicesReportComponent, PositionReportComponent, TravelReportComponent],
  entryComponents: [],
  providers: [],
})
export class ReportsModule { }
