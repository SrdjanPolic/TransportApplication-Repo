import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { VendorListComponent } from '../vendor-list/vendor-list.component';
import { VendorDetailsComponent } from '../vendor-details/vendor-details.component';
import { VendorCreateComponent } from '../vendor-create/vendor-create.component';
import { VendorUpdateComponent } from '../vendor-update/vendor-update.component';
import { VendorDeleteComponent } from 'src/app/vendor/vendor-delete/vendor-delete.component';

const routes: Routes = [
  { path: 'vendors', component: VendorListComponent },
  { path: 'details/:id', component: VendorDetailsComponent },
  { path: 'create', component: VendorCreateComponent },
  { path: 'update/:id', component: VendorUpdateComponent },
  { path: 'delete/:id', component: VendorDeleteComponent }
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
export class VendorRoutingModule { }
