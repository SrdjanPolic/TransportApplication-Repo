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
  { path: 'customer', loadChildren: './../customer/customer.module#CustomerModule' , canActivate: [AuthGuard]},
  { path: 'vendor', loadChildren: './../vendor/vendor.module#VendorModule', canActivate: [AuthGuard]},
  { path: 'purchase', loadChildren: './../purchase/purchase.module#PurchaseModule', canActivate: [AuthGuard]},
  { path: 'sales', loadChildren: './../sales/sales.module#SalesModule', canActivate: [AuthGuard]},
  { path: 'vehicle', loadChildren: './../vehicle/vehicle.module#VehicleModule', canActivate: [AuthGuard]},
  { path: 'driver', loadChildren: './../driver/driver.module#DriverModule', canActivate: [AuthGuard]},
  { path: 'user', loadChildren: './../user/user.module#UserModule', canActivate: [AuthGuard]},
  { path: 'currencyExchange', loadChildren: './../currencyExchange/currencyExchange.module#CurrencyExchangeModule',
  canActivate: [AuthGuard]},
  { path: 'reports', loadChildren: './../reports/reports.module#ReportsModule', canActivate: [AuthGuard]},
  { path: '404', component: NotFoundComponent },
  { path: '500', component: ServerErrorComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full'},
  { path: '**', redirectTo: '/404', pathMatch: 'full' }

];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(ownerRoutes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class RoutingModule { }
