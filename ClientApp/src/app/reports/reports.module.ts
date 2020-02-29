import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule} from './reports-routing/reports-routing.module';
import { TravelOrderComponent} from './travel-order/travel-order.component';
import {FormsModule} from '@angular/forms';
import {TransformModule} from '../shared/transform/transform.module';
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
  declarations: [TravelOrderComponent],
  entryComponents: [],
  providers: [],
})
export class ReportsModule { }
