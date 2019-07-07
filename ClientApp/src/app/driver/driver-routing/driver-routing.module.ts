import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DriverListComponent } from '../driver-list/driver-list.component';
import { DriverCreateComponent } from '../driver-create/driver-create.component';
import { DriverUpdateComponent } from '../driver-update/driver-update.component';
import { DriverDeleteComponent } from '../driver-delete/driver-delete.component';

const routes: Routes = [
  { path: 'drivers', component: DriverListComponent },
  { path: 'create', component: DriverCreateComponent },
  { path: 'update/:id', component: DriverUpdateComponent },
  { path: 'delete/:id', component: DriverDeleteComponent }
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
export class DriverRoutingModule { }
