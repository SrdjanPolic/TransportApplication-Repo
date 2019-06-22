import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { NotFoundComponent } from '../error-pages/not-found/not-found.component';
import { ServerErrorComponent } from '../error-pages/server-error/server-error.component';
import { AuthGuard } from '../auth/auth.guard';
import { LoginComponent } from '../login/login.component';
import {LoginLayoutComponent} from './../layout/login-layout.component';
import {LayoutComponent} from './../layout/layout.component';

const ownerRoutes: Routes = [
  
  {path: 'login', component: LoginComponent},
  { path: 'home', component: HomeComponent },
  { path: 'customer', loadChildren: "./../customer/customer.module#CustomerModule" },
  { path: 'vendor', loadChildren: "./../vendor/vendor.module#VendorModule" },
  { path: 'purchase', loadChildren: "./../purchase/purchase.module#PurchaseModule"},
  { path: 'sales', loadChildren: "./../sales/sales.module#SalesModule"},
  { path: '404', component: NotFoundComponent },
  { path: '500', component: ServerErrorComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full'},
  { path: '**', redirectTo: '/404', pathMatch: 'full' }
  
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(ownerRoutes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class RoutingModule { }
