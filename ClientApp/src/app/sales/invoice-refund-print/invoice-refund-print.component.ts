import { SalesInvService } from './../../shared/SalesInv.service';
import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { NgForm, Validators } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { InvoiceLinesComponent } from '../../sales/invoice-lines/invoice-lines.component';
import { Customer } from '../../_interface/customer.model';
import { Currency } from '../../_interface/Currency.model';
import { Driver } from '../../_interface/driver.model';
import { Vehicle } from '../../_interface/vehicle.model';
import {User} from '../../auth/user.model';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { Settings } from 'src/app/_interface/Settings.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Location } from '@angular/common';
import {CurrencyExchange} from '../../_interface/currencyExchange.model';
declare const number2Words: any;

@Component({
  selector: 'app-invoice-refund-print',
  templateUrl: './invoice-refund-print.component.html',
  styleUrls: ['./invoice-refund-print.component.css'],

})
export class InvoiceRefundPrintComponent implements OnInit {
  customer: Customer;
  driver: Driver;
  vehicle: Vehicle;
  user: User;
  isValid = true;
  currency: Currency;
  currExchange: CurrencyExchange;
  settings: Settings;
  private dialogConfig;
  invoiceIdForPrint: string;
  numberToWordsString: string;
  VATAmount: number;
  BaseAmount: number;

  constructor(public service: SalesInvService,
    private dialog: MatDialog,
    private repoService: RepositoryService,
    private toastr: ToastrService,
    private router: Router,
    private errorService: ErrorHandlerService,
    private location: Location,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    const invoiceID = this.currentRoute.snapshot.paramMap.get('id');
    if (invoiceID == null) {
      this.resetForm();
    } else {
      // tslint:disable-next-line: radix
      this.service.getInvoiceByID(parseInt(invoiceID)).then(res => {
        this.service.formData = res;
        this.service.SalesInvLines = res.lines;
        this.service.formData.deletedInvoiceLineIds = '';
        this.invoiceIdForPrint = invoiceID;
        const customerByIdUrl = `api/Customers/${this.service.formData.customerId}`;
        this.repoService.getData(customerByIdUrl).subscribe(res2 => this.customer = res2 as Customer);
        this.VATAmount = this.service.SalesInvLines.reduce((prev, curr) => {
          return prev + (curr.lineAmount - (curr.unitPrice * curr.quantity));
        }, 0);
        this.BaseAmount = this.service.SalesInvLines.reduce((prev, curr) => {
          return prev + (curr.unitPrice * curr.quantity);
        }, 0);
      });

    }

  }
  callconvertNumToWords(amount: number) {
    this.numberToWordsString = number2Words(amount);
  }

  resetForm(form?: NgForm) {
    const newDt = new Date();
    if (form = null) {
     form.resetForm();
    }
    this.service.formData = {
      id: 0,
      invoiceNo: 'Biće automatski dodeljen',
      postingDate: new Date(),
      externalReferenceNo: '',
      dueDate: new Date(newDt.setDate(newDt.getDate() + 14)),
      salesPerson: '',
      orderDate: new Date(),
      totalAmount: 0,
      totalAmountLocal: 0,
      paid: false,
      invoiced: false,
      creditMemo: false,
      paymentDate: new Date(),
      commodityType: '',
      numberOfPallets: 0,
      numberOfPalletsPlaces: 0,
      bruttoWeight: 0,
      adrNeeded: false,
      remarks: '',
      vechicleRegistration: '',
      driverName: '',
      routeDistance: 0,
      loadRepresentative: '',
      pricePerKm: 0,
      crmNumber: '',
      deletedInvoiceLineIds: '',
      currencyId: 0,
      customerId: 0,
      travelOrder: '',
      partiallyPayed : 0,
      checkIssueDate: new Date(),
      taxLawText : '',
      loadAddress: '',
      unloadAddress: '',
      clienReceiptDocDate: new Date(),
      ownTransport: false,
      loadDate: new Date(),
      unloadDate: new Date(),
      customerName: '',
      calculatonExchangeRate: 0,
      lastChangeDateTime: new Date(),
      lastChangeUserId: 0
    };
    this.service.SalesInvLines = [];
  }

  test(value) {
    console.log(value);
  }
  onPrintInvoice() {
    // this.printService
    //   .printDocument('invoice', this.invoiceIdForPrint);
  }

}
