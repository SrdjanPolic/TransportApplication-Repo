import { Injectable } from '@angular/core';
import {MatSnackBar, MatSnackBarConfig} from '@angular/material';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  constructor(public SnackBar : MatSnackBar) { }

  config: MatSnackBarConfig = {
    duration: 3000,
    horizontalPosition: 'right',
    verticalPosition: 'top'
  }

  success(msg: string) {
    this.config['panelClass'] = ['notification', 'success'];
    this.SnackBar.open(msg, '', this.config);
  }

  warn(msg: string) {
    this.config['panelClass'] = ['notification','warn'];
    this.SnackBar.open(msg,'',this.config);
  }
}
