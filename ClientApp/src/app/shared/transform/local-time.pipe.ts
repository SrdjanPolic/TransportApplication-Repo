import { PipeTransform, Pipe} from '@angular/core';
import * as moment from 'moment';
@Pipe({
  name: 'localTime'
})
export class LocalTimePipe implements PipeTransform {
  transform(time) {
    return moment.utc(time).local().format('DD.MM.YYYY.');
  }
}
