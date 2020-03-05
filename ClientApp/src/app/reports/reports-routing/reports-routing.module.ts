import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import {TravelOrderComponent} from './../travel-order/travel-order.component';

const routes: Routes = [
  { path: 'TravelOrder', component: TravelOrderComponent },
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
