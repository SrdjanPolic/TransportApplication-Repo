import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserListComponent } from './../user/user-list/user-list.component';
import { UserRoutingModule } from './../user/user-routing/user-routing.module';
import { UserCreateComponent } from './../user/user-create/user-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { UserUpdateComponent } from './../user/user-update/user-update.component';
import { UserDeleteComponent } from './../user/user-delete/user-delete.component';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [UserListComponent, UserCreateComponent, UserUpdateComponent, UserDeleteComponent]
})
export class UserModule { }
