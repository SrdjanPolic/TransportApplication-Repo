import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {TransformCurrencyPipe} from './transformCurrency.pipe';
import {TransformbooleanPipe} from './transformboolean.pipe';
@NgModule({
  declarations: [TransformbooleanPipe,TransformCurrencyPipe],
  imports: [
    CommonModule
  ],
  exports: [TransformbooleanPipe,TransformCurrencyPipe],
  //providers: [TransformbooleanPipe,TransformCurrencyPipe]
})
export class TransformModule { }
