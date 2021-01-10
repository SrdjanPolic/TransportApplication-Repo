import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule} from './reports-routing/reports-routing.module';
import { SalesInvoicesReportComponent} from './sales-invoices/sales-invoices.component';
import { PositionReportComponent} from './position-report/position-report.component';
import { TravelReportComponent} from './travel-report/travel-report.component';
import { TravelReportDetailComponent} from './travel-report-detail/travel-report-detail.component';
import { PositionReportDetailComponent} from './position-report-detail/position-report-detail.component';
import { FormsModule} from '@angular/forms';
import { TransformModule} from '../shared/transform/transform.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { MatTableExporterModule} from 'mat-table-exporter';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule,
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    MatTableExporterModule,
    TransformModule
  ],
  declarations: [SalesInvoicesReportComponent, PositionReportComponent, TravelReportComponent,TravelReportDetailComponent,PositionReportDetailComponent],
  entryComponents: [],
  providers: [],
})
export class ReportsModule { }
