import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'transformboolean'
})
export class TransformbooleanPipe implements PipeTransform {

  transform(value: boolean): string {
    return value === true ? 'Da' : 'Ne';
  }

}
