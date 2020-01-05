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

@Component({
  selector: 'app-invoice-print',
  templateUrl: './invoice-print.component.html',
  styles: ['./invoice-print.component.css']
})
export class InvoicePrintComponent implements OnInit {
  customer: Customer;
  driver: Driver;
  vehicle: Vehicle;
  user: User;
  isValid = true;
  currency: Currency;
  settings: Settings;
  private dialogConfig;
  invoiceIdForPrint: string;
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
      });
      //window.print();
      //this.location.back();

    }
    let customerByIdUrl: string = `api/Customers/${this.service.formData.customerId}`;
    this.repoService.getData(customerByIdUrl).subscribe(res => this.customer = res as Customer);
    // this.repoService.getData('api/Currency').subscribe(res => this.currencyList = res as Currency[]);
    // this.repoService.getData('api/Drivers').subscribe(res => this.driverList = res as Driver[]);
    // this.repoService.getData('api/Vehicles').subscribe(res => this.vehicleList = res as Vehicle[]);
    // this.repoService.getData('api/Users').subscribe(res => this.userList = res as User[]);
  }

  resetForm(form?: NgForm) {
    const newDt = new Date();
    if (form = null) {
     form.resetForm();
    }
    this.service.formData = {
      id: 0,
      invoiceNo: 'Biće automatski dodeljen',
      postingDate: newDt,
      externalReferenceNo: '',
      dueDate: new Date(newDt.setDate(newDt.getDate() + 14)),
      salesPerson: '',
      orderDate: newDt,
      totalAmount: 0,
      totalAmountLocal: 0,
      paid: false,
      invoiced: false,
      creditMemo: false,
      paymentDate: new Date(),
      commodityType: '',
      numberOfPallets: 0,
      numberofPalletsPlaces: 0,
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
      lastChangeDateTime: newDt.toLocaleString(),
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

  convertNumberToWords(amount) {
    var words = new Array();
    words[0] = '';
    words[1] = 'jedan';
    words[2] = 'dva';
    words[3] = 'tri';
    words[4] = 'četiri';
    words[5] = 'pet';
    words[6] = 'šest';
    words[7] = 'sedam';
    words[8] = 'osam';
    words[9] = 'devet';
    words[10] = 'deset';
    words[11] = 'jedanaest';
    words[12] = 'dvanaest';
    words[13] = 'trinaest';
    words[14] = 'četrnaest';
    words[15] = 'petnaest';
    words[16] = 'šesnaest';
    words[17] = 'sedamnaest';
    words[18] = 'osamnaest';
    words[19] = 'devetnaest';
    words[20] = 'dvadeset';
    words[30] = 'trideset';
    words[40] = 'četrdeset';
    words[50] = 'pedeset';
    words[60] = 'šezdeset';
    words[70] = 'sedamdeset';
    words[80] = 'osamdeset';
    words[90] = 'devedeset';
    amount = amount.toString();
    var atemp = amount.split(".");
    var number = atemp[0].split(",").join("");
    var n_length = number.length;
    var words_string = "";
    var value;
    if (n_length <= 9) {
        var n_array = new Array(0, 0, 0, 0, 0, 0, 0, 0, 0);
        var received_n_array = new Array();
        for (var i = 0; i < n_length; i++) {
            received_n_array[i] = number.substr(i, 1);
        }
        for (var i = 9 - n_length, j = 0; i < 9; i++, j++) {
            n_array[i] = received_n_array[j];
        }
        for (var i = 0, j = 1; i < 9; i++, j++) {
            if (i == 0 || i == 2 || i == 4 || i == 7) {
                if (n_array[i] == 1) {
                    n_array[j] = 10 + (n_array[j]);
                    n_array[i] = 0;
                }
            }
        }
        value = "";
        for (var i = 0; i < 9; i++) {
            if (i == 0 || i == 2 || i == 4 || i == 7) {
                value = n_array[i] * 10;
            } else {
                value = n_array[i];
            }
            if (value != 0) {
                words_string += words[value];
            }
            if ((i == 1 && value != 0) || (i == 0 && value != 0 && n_array[i + 1] == 0)) {
                words_string += "Crores ";
            }
            if ((i == 3 && value != 0) || (i == 2 && value != 0 && n_array[i + 1] == 0)) {
                words_string += "Lakhs ";
            }
            if ((i == 5 && value != 0) || (i == 4 && value != 0 && n_array[i + 1] == 0)) {
                words_string += "hiljada";
            }
            if (i == 6 && value != 0 && (n_array[i + 1] != 0 && n_array[i + 2] != 0)) {
                words_string += "hiljadai";
            } else if (i == 6 && value != 0) {
                words_string += "sto";
            }
        }
        words_string = words_string.split("  ").join(" ");
    }
    return (words_string + 'dinara i 00/100');
  }


}
