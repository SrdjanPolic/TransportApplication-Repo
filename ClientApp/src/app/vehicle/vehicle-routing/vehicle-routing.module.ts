import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { VehicleListComponent } from '../vehicle-list/vehicle-list.component';
//import { CustomerDetailsComponent } from '../customer-details/customer-details.component';
import { VehicleCreateComponent } from '../vehicle-create/vehicle-create.component';
import { VehicleUpdateComponent } from '../vehicle-update/vehicle-update.component';
import { VehicleDeleteComponent } from '../vehicle-delete/vehicle-delete.component';

const routes: Routes = [
  { path: 'vehicles', component: VehicleListComponent },
  { path: 'create', component: VehicleCreateComponent },
  { path: 'update/:id', component: VehicleUpdateComponent },
  { path: 'delete/:id', component: VehicleDeleteComponent }
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
export class VehicleRoutingModule { }
