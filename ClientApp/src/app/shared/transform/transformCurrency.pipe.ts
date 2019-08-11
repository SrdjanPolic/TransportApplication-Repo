import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'transformcurrency'
})
export class TransformCurrencyPipe implements PipeTransform {

  transform(value: null): string {
    return value === 1 ? 'DIN' : 'EUR';
  }

}
