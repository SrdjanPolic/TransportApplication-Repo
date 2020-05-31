import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { SalesInvoicesReportComponent} from './../sales-invoices/sales-invoices.component';
import { PositionReportComponent } from './../position-report/position-report.component';
import { TravelReportComponent } from './../travel-report/travel-report.component';

const routes: Routes = [
  { path: 'PositionReport', component: PositionReportComponent },
  { path: 'TravelReport', component: TravelReportComponent},
  { path: 'SalesInvoicesReport', component: SalesInvoicesReportComponent }
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
export class ReportsRoutingModule { }
