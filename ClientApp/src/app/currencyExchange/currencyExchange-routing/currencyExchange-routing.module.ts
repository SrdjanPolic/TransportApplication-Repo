import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CurrencyExchangeListComponent } from '../currencyExchange-list/currencyExchange-list.component';
import { CurrencyExchangeCreateComponent } from '../currencyExchange-create/currencyExchange-create.component';
import { CurrencyExchangeUpdateComponent } from '../currencyExchange-update/currencyExchange-update.component';
import { CurrencyExchangeDeleteComponent } from '../currencyExchange-delete/currencyExchange-delete.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: 'ExchangeRate', component: CurrencyExchangeListComponent },
  { path: 'create', component: CurrencyExchangeCreateComponent },
  { path: 'update/:id', component: CurrencyExchangeUpdateComponent },
  { path: 'delete/:id', component: CurrencyExchangeDeleteComponent }
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
export class CurrencyExchangeRoutingModule { }
