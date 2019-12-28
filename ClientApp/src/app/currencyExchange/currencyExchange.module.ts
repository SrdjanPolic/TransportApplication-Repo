import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CurrencyExchangeListComponent } from './currencyExchange-list/currencyExchange-list.component';
import { CurrencyExchangeRoutingModule } from './currencyExchange-routing/currencyExchange-routing.module';
import { CurrencyExchangeCreateComponent } from './currencyExchange-create/currencyExchange-create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { CurrencyExchangeUpdateComponent } from './currencyExchange-update/currencyExchange-update.component';
import { CurrencyExchangeDeleteComponent } from './currencyExchange-delete/currencyExchange-delete.component';

@NgModule({
  imports: [
    CommonModule,
    CurrencyExchangeRoutingModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [CurrencyExchangeListComponent, CurrencyExchangeCreateComponent, CurrencyExchangeUpdateComponent, CurrencyExchangeDeleteComponent]
})
export class CurrencyExchangeModule { }
