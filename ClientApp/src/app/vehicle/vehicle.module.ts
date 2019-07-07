import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VehicleListComponent } from './vehicle-list/vehicle-list.component';
import { VehicleRoutingModule } from './vehicle-routing/vehicle-routing.module';
import { VehicleCreateComponent } from './vehicle-create/vehicle-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { VehicleUpdateComponent } from './vehicle-update/vehicle-update.component';
import { VehicleDeleteComponent } from './vehicle-delete/vehicle-delete.component';

@NgModule({
  imports: [
    CommonModule,
    VehicleRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [VehicleListComponent, VehicleCreateComponent, VehicleUpdateComponent, VehicleDeleteComponent]
})
export class VehicleModule { }
