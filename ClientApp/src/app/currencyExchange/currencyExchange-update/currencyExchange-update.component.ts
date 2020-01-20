import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { CurrencyExchange } from '../../_interface/currencyExchange.model';
import { Currency } from '../../_interface/Currency.model';

@Component({
  selector: 'app-currencyExchange-update',
  templateUrl: './currencyExchange-update.component.html',
  styleUrls: ['./currencyExchange-update.component.css']
})
export class CurrencyExchangeUpdateComponent implements OnInit {

  public currencyExchangeForm: FormGroup;
  private dialogConfig;
  public currencyExchange: CurrencyExchange;
  currencyList: Currency[];

  constructor(private location: Location, private repository: RepositoryService,
    private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

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
    this.getcurrencyExchangeById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.currencyExchangeForm.controls[controlName].hasError(errorName);
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

  private getcurrencyExchangeById = () => {
    const currencyExchangeId: string = this.activeRoute.snapshot.params['id'];

    const currencyExchangeByIdUrl: string = `api/ExchangeRate/${currencyExchangeId}`;

    this.repository.getData(currencyExchangeByIdUrl)
      .subscribe(res => {
        this.currencyExchange = res as CurrencyExchange;
        this.currencyExchangeForm.patchValue(this.currencyExchange);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateCurrencyExchange = (currencyExchangeFormValue) => {
    if (this.currencyExchangeForm.valid) {
      this.executeCurrencyExchangeUpdate(currencyExchangeFormValue);
    }
  }

  private executeCurrencyExchangeUpdate = (currencyExchangeFormValue) => {

    this.currencyExchange.currencyId = currencyExchangeFormValue.currencyId,
    this.currencyExchange.startingDate = this.setDate('startingDate'),
    this.currencyExchange.exchangeRateAmount = currencyExchangeFormValue.exchangeRateAmount,
    this.currencyExchange.lastChangeUserId = +this.userId;

    let apiUrl = `api/ExchangeRate/${this.currencyExchange.id}`;
    this.repository.update(apiUrl, this.currencyExchange)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);

        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
      (error => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
    );
  }

}
