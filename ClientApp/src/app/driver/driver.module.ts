import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DriverListComponent } from './driver-list/driver-list.component';
import { DriverRoutingModule } from './driver-routing/driver-routing.module';
import { DriverCreateComponent } from './driver-create/driver-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { DriverUpdateComponent } from './driver-update/driver-update.component';
import { DriverDeleteComponent } from './driver-delete/driver-delete.component';

@NgModule({
  imports: [
    CommonModule,
    DriverRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [DriverListComponent, DriverCreateComponent, DriverUpdateComponent, DriverDeleteComponent]
})
export class DriverModule { }
