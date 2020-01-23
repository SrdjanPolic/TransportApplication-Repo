import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { CurrencyExchangeForCreation } from '../../_interface/currencyExchangeForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Currency } from '../../_interface/Currency.model';

@Component({
  selector: 'app-currencyExchange-create',
  templateUrl: './currencyExchange-create.component.html',
  styleUrls: ['./currencyExchange-create.component.css']
})
export class CurrencyExchangeCreateComponent implements OnInit {
  public currencyExchangeForm: FormGroup;
  private dialogConfig;
  currencyList: Currency[];

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    let newDt = new Date();
    this.currencyExchangeForm = new FormGroup({
      currencyId: new FormControl(0, Validators.required),
      startingDate: new FormControl(newDt, Validators.required),
      exchangeRateAmount: new FormControl(0, Validators.required),

    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }
    this.repository.getData('api/Currency').subscribe(res => this.currencyList = res as Currency[]);
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.currencyExchangeForm.controls[controlName].hasError(errorName);
  }

  public isFieldInvalid(field: string) {
    return (
      (!this.currencyExchangeForm.get(field).valid && this.currencyExchangeForm.get(field).touched) ||
      (this.currencyExchangeForm.get(field).untouched)
    );
  }

  public onCancel = () => {
    this.location.back();
  }

  get userId(): string {
    return localStorage.getItem('userId');
  }

  public setDate(control: string): Date {
    const chosenDate = new Date(this.currencyExchangeForm.get(control).value);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  public createCurrencyExchange = (currencyExchangeValue) => {
    if (this.currencyExchangeForm.valid) {
      this.executeCurrencyExchangeForCreation(currencyExchangeValue);
    }
  }

  private executeCurrencyExchangeForCreation = (currencyExchangeValue) => {
    const currencyExchange: CurrencyExchangeForCreation = {
      currencyId: currencyExchangeValue.currencyId,
      startingDate: currencyExchangeValue.startingDate,
      exchangeRateAmount: currencyExchangeValue.exchangeRateAmount,
      lastChangeDateTime: new Date(),
      lastChangeUserId: +this.userId
    }

    currencyExchange.startingDate = this.setDate('startingDate');

    const apiUrl = 'api/ExchangeRate';
    this.repository.create(apiUrl, currencyExchange)
      .subscribe(res => {
        const dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);

        //we are subscribing on the [mat-dialog-close] attribute as soon as we click on the dialog button
        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
        (error => {
          this.errorService.dialogConfig = { ...this.dialogConfig };
          this.errorService.handleError(error);
        })
      )
  }

}
