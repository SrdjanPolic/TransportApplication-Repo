import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {TransformCurrencyPipe} from './transformCurrency.pipe';
import {TransformbooleanPipe} from './transformboolean.pipe';
import {LocalTimePipe} from './local-time.pipe';
@NgModule({
  declarations: [TransformbooleanPipe, TransformCurrencyPipe,LocalTimePipe],
  imports: [
    CommonModule
  ],
  exports: [TransformbooleanPipe, TransformCurrencyPipe, LocalTimePipe],
  //providers: [TransformbooleanPipe,TransformCurrencyPipe]
})
export class TransformModule { }
