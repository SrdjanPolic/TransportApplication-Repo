import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { CurrencyExchange } from '../../_interface/currencyExchange.model';

@Component({
  selector: 'app-currencyExchange-delete',
  templateUrl: './currencyExchange-delete.component.html',
  styleUrls: ['./currencyExchange-delete.component.css']
})
export class CurrencyExchangeDeleteComponent implements OnInit {

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
    private activeRoute: ActivatedRoute) { }

    private dialogConfig;
    public currencyExchange: CurrencyExchange;

  ngOnInit() {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    };

    this.getCurrencyExchangeById();
  }

  public onCancel = () => {
    this.location.back();
  }

  private getCurrencyExchangeById = () => {
    let currencyExchangeId: string = this.activeRoute.snapshot.params['id'];

    let currencyExchangeByIdUrl: string = `api/CurrencyExchange/${currencyExchangeId}`;

    this.repository.getData(currencyExchangeByIdUrl)
      .subscribe(res => {
        this.currencyExchange = res as CurrencyExchange;
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      });
  }

  public deleteCurrencyExchange = () => {
    let deleteUrl: string = `api/CurrencyExchange/${this.currencyExchange.id}`;
    this.repository.delete(deleteUrl)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);

        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      });
  }

}
