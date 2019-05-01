import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NavMenu2Component } from './nav-menu2/nav-menu2.component';
import { CommonModule } from '@angular/common';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'customer', loadChildren: "./customer/customer.module#CustomerModule"},
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  imports: [CommonModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
