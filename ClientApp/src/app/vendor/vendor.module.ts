import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VendorListComponent } from './vendor-list/vendor-list.component';
import { VendorRoutingModule } from './vendor-routing/vendor-routing.module';
import { VendorDetailsComponent } from './vendor-details/vendor-details.component';
import { VendorDataComponent } from './vendor-details/vendor-data/vendor-data.component';
import { AccountDataComponent } from './vendor-details/account-data/account-data.component';
import { VendorCreateComponent } from './vendor-create/vendor-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { VendorUpdateComponent } from './vendor-update/vendor-update.component';
import { VendorDeleteComponent } from './vendor-delete/vendor-delete.component';

@NgModule({
  imports: [
    CommonModule,
    VendorRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [VendorListComponent, VendorDetailsComponent, VendorDataComponent, AccountDataComponent, VendorCreateComponent, VendorUpdateComponent, VendorDeleteComponent]
})
export class VendorModule { }
