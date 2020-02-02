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

@Component({
  selector: 'app-invoice-print',
  templateUrl: './invoice-print.component.html',
  styleUrls: ['./invoice-print.component.css'],

})
export class InvoicePrintComponent implements OnInit {
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
  brojka; ost ; k: number;
  slo; slo1; slo2; slo3; bro; bro1: string;
  brojk: any;

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
        const currid = 2;  // eur
        const apiUrl = `api/ExchangeRate/${currid}/${this.service.formData.checkIssueDate}`;
        this.repoService.getData(apiUrl).subscribe(res3 => this.currExchange = res3 as CurrencyExchange);
      });

    }

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

  convertNumberToWords(amount) {
    let words = new Array();
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
    let atemp = amount.split('.');
    let number = atemp[0].split(',').join('');
    let n_length = number.length;
    let words_string = '';
    let value;
    if (n_length <= 9) {
        let n_array = new Array(0, 0, 0, 0, 0, 0, 0, 0, 0);
        let received_n_array = new Array();
        for (let i = 0; i < n_length; i++) {
            received_n_array[i] = number.substring(i, 1);
        }
        for (let i = 9 - n_length, j = 0; i < 9; i++, j++) {
            n_array[i] = received_n_array[j];
        }
        for (let i = 0, j = 1; i < 9; i++, j++) {
            if (i == 0 || i == 2 || i == 4 || i == 7) {
                if (n_array[i] == 1) {
                    n_array[j] = 10 + (n_array[j]);
                    n_array[i] = 0;
                }
            }
        }
        value = '';
        for (let i = 0; i < 9; i++) {
            if (i == 0 || i == 2 || i == 4 || i == 7) {
                value = n_array[i] * 10;
            } else {
                value = n_array[i];
            }
            if (value != 0) {
                words_string += words[value];
            }
            if ((i == 1 && value != 0) || (i == 0 && value != 0 && n_array[i + 1] == 0)) {
                words_string += 'Crores ';
            }
            if ((i == 3 && value != 0) || (i == 2 && value != 0 && n_array[i + 1] == 0)) {
                words_string += 'Lakhs ';
            }
            if ((i == 5 && value != 0) || (i == 4 && value != 0 && n_array[i + 1] == 0)) {
                words_string += 'hiljada';
            }
            if (i == 6 && value != 0 && (n_array[i + 1] != 0 && n_array[i + 2] != 0)) {
                words_string += 'hiljadai';
            } else if (i == 6 && value != 0) {
                words_string += 'sto';
            }
        }
        words_string = words_string.split('  ').join(' ');
    }
    return (words_string + 'dinara i 00/100');
  }


 broj2slo(brojka: number) {

    let k: number;
    this.slo = ' Din ';
    this.slo1 = ' ';
    this.slo2 = ' ';
    this.slo3 = ' ';
    // brojka=12456.99

     this.brojk = Math.round(brojka);

        if (brojka > this.brojk) {
             this.ost = Math.abs((brojka - this.brojk) * 100);
            } else {
            this.ost = Math.abs((this.brojk - brojka) * 100);
            this.ost = 100 - this.ost;
            }

        this.ost = Math.round(this.ost);

        if (this.ost > 0 && this.ost != 100) {
          this.ost = String(this.ost);
          this.ost = this.ost.substring(0, 2);
          this.ost = this.ost.replace('.', ' ');
          this.slo = this.slo + '  i ' + this.ost + '/100';
           }
        this.brojk = String(this.brojk);
        this.brojk = '000000000' + this.brojk;
        this.brojk = this.brojk.length;
       this.brojk = this.brojk.substring(this.brojk.length - 9, 9);
       if ( eval(this.brojk) == 0) {
          this.slo = ' Nula Din. ';
         }
 for (k = 0; k <= 8; k++) {
    this.bro = this.brojk.substring(8 - k, 1);
       if (k == 0 || k == 3 || k == 6 ) {
          this.slo_a(k);
          if (k == 3 && eval(this.brojk.substring(4, 3)) > 0) {
             if (this.bro == '2'  || this.bro == '3' || this.bro == '4') {this.slo = 'hiljade' + this.slo; } else {this.slo = 'hiljada' + this.slo; }
              if (eval(this.brojk.substring(5, 2)) >= 12 || eval(this.brojk.substring(5, 2)) <= 14) {this.slo = this.slo.replace('hiljdade', 'hiljada'); }

             }
            if (k == 6 && eval(this.brojk.substring(1, 3)) > 0) {
                  if (this.bro == '1') {
                    this.slo = 'milion' + this.slo;
                   } else if (this.bro > 1) {
                    this.slo = this.bro.toString + 'miliona' + this.slo;
                 }
               }

          }




    if (k == 1 || k == 4 || k == 7) {
        if (!(this.bro == '1')) {
          this.slo = this.slo1 + this.slo;
          this.slo = this.slo.replace('  ', '');
             }
        this.slo_b(k);
        this.slo = this.slo2 + this.slo;
        }

    if (k == 2 || k == 5 || k == 8) {
        this.slo_c();
        this.slo = this.slo3 + this.slo;
        this.slo = this.slo.replace('  ', '');
        }



        this.slo = this.slo.replace('  ', '');

   }

 return(this.slo);

}


slo_a(k: number) {
 if ( this.bro == '1') {
  this.slo1 = 'jedna';
   if ( k == 6) {
    this.slo1 = 'jedan';
   }
  }
 if (this.bro == '2') {
  this.slo1 = 'dve';
   if (k == 6) {
    this.slo1 = 'dva';
        }
    }
  if (this.bro == '3') {
    this.slo1 = 'tri';
  }
 if ( this.bro == '4') {
  this.slo1 = 'četiri';
 }
 if (this.bro == '5') {
  this.slo1 = 'pet';
}
 if (this.bro == '6') {
  this.slo1 = 'šest';
 }
if (this.bro == '7') {
  this.slo1 = 'sedam';
 }
 if ( this.bro == '8') {
  this.slo1 = 'osam';
 }

 if ( this.bro == '9') {
  this.slo1 = 'devet';
 }
 if (this.bro == '0') {
  this.slo1 = '  ';
 }

 return this.slo1;
 }

slo_b(k: number) {
 if (this.bro == '2') {this.slo2 = 'dvadeset'; }
 if (this.bro == '3') {this.slo2 = 'tridesed'; }
 if (this.bro == '4') {this.slo2 = 'četrdeset'; }
 if (this.bro == '5') {this.slo2 = 'pedeset'; }
 if (this.bro == '6') {this.slo2 = 'šezdeset'; }
 if (this.bro == '7') {this.slo2 = 'sedamdeset'; }
 if (this.bro == '8') {this.slo2 = 'osamdeset'; }
 if (this.bro == '9') {this.slo2 = 'devedeset'; }
 if (this.bro == '0') {this.slo2 = '  '; }
  if (this.bro == '1') {
    this.bro1 = this.brojk.substring(9 - k, 1);
  if (this.bro1 == '0') {
  this.slo2 = 'deset';
  }
  }
  if (this.bro1 == '1') {this.slo2 = 'jedanaest'; }
  if (this.bro1 == '2') {this.slo2 = 'dvanaest'; }
 if (this.bro1 == '3') {this.slo2 = 'trinaest'; }
 if (this.bro1 == '4') {this.slo2 = 'četrnaest'; }
 if (this.bro1 == '5') {this.slo2 = 'petnaest'; }
 if (this.bro1 == '6') {this.slo2 = 'šesnaest'; }
 if (this.bro1 == '7') {this.slo2 = 'sedamnaest'; }
 if (this.bro1 == '8') {this.slo2 = 'osamnaest'; }
 if (this.bro1 == '9') {this.slo2 = 'devetnaest'; }


  return (this.slo2);

}

slo_c() {
if (this.bro == '1') {this.slo3 = 'sto'; }
 if (this.bro == '2') {this.slo3 = 'dvesta'; }
 if (this.bro == '3') {this.slo3 = 'trista'; }
 if (this.bro == '4') {this.slo3 = 'četiristo'; }
 if (this.bro == '5') {this.slo3 = 'petsto'; }
 if (this.bro == '6') {this.slo3 = 'šesto'; }
 if (this.bro == '7') {this.slo3 = 'sedamsto'; }
 if (this.bro == '8') {this.slo3 = 'osamsto'; }
 if (this.bro == '9') {this.slo3 = 'devetsto'; }
 if (this.bro == '0') {this.slo3 = '  '; }
return this.slo3;
 }
}
