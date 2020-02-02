import { PrintService } from './../../shared/print.service';
import { SalesInvService } from './../../shared/SalesInv.service';
import { RepositoryService } from './../../shared/repository.service';
// import { OrderService } from './../../shared/order.service';
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
import {CurrencyExchange} from '../../_interface/currencyExchange.model';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styles: []
})
export class InvoiceComponent implements OnInit {
  customerList: Customer[];
  driverList: Driver[];
  vehicleList: Vehicle[];
  currExchange: CurrencyExchange;
  userList: User[];
  isValid = true;
  currencyList: Currency[];
  settings: Settings;
  private dialogConfig;
  invoiceIdForPrint: string;
  isPostedInvoice: boolean;
  isCreditMemoInvoice: boolean;
  exchangeRateValue: number;
  TaxLawLongTextSerbian: string;
  TaxLawLongTextEnglish: string;

  constructor(public service: SalesInvService,
    private dialog: MatDialog,
    private repoService: RepositoryService,
    private toastr: ToastrService,
    private router: Router,
    private errorService: ErrorHandlerService,
    public printService: PrintService,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    const invoiceID = this.currentRoute.snapshot.paramMap.get('id');
    this.repoService.getData('api/Customers').subscribe(res => this.customerList = res as Customer[]);
    this.repoService.getData('api/Currency').subscribe(res => this.currencyList = res as Currency[]);
    this.repoService.getData('api/Users').subscribe(res => this.userList = res as User[]);
    this.repoService.getData('api/Drivers').subscribe(res => this.driverList = res as Driver[]);
    this.repoService.getData('api/Vehicles').subscribe(res => this.vehicleList = res as Vehicle[]);

    this.TaxLawLongTextEnglish = `Original CMR is enclosed, as well as EX document. In case of payment delay, the
    interest rate is 0,4% per day of above amount  till the day of actual payment.
    All claims are beeing accepted until the moment when the truck is discharged.` ;
    this.TaxLawLongTextSerbian = `Oslobođenje PDV-a po članu 24 stav 1 tačka 1 Zakona o pdv
    (Sl. glasnik 84/2004, 86/2004, ispravka 14/2014, 83/2015, 108/2016).`;
    if (invoiceID == null) {
      this.resetForm();
    } else {
      // tslint:disable-next-line: radix
      this.service.getInvoiceByID(parseInt(invoiceID)).then(res => {
        this.service.formData = res;
        this.service.SalesInvLines = res.lines;
        this.service.formData.deletedInvoiceLineIds = '';
        this.invoiceIdForPrint = invoiceID;
        this.isPostedInvoice = res.invoiced;
        this.isCreditMemoInvoice = res.creditMemo;
        this.service.formData.lastChangeUserId = +this.userId;
        const currid2 = 2;
        // if (typeof currid === 'undefined') {
        //   currid = 2;  //eur
        // }
        let postingDate2 = res.clienReceiptDocDate;
        if (typeof postingDate2 === 'undefined') {
          postingDate2 = new Date();
        }
        const apiUrl2 = `api/ExchangeRate/${currid2}/${postingDate2}`;
        this.repoService.getData(apiUrl2).subscribe(res2 => this.currExchange = res2 as CurrencyExchange);

      });
    }
  }

  get isAdmin(): string {
    return localStorage.getItem('isAdmin');
  }

  get userId(): string {
    return localStorage.getItem('userId');
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
      taxLawText : this.TaxLawLongTextSerbian,
      loadAddress: '',
      unloadAddress: '',
      clienReceiptDocDate: new Date(),
      ownTransport: false,
      loadDate: new Date(),
      unloadDate: new Date(),
      calculatonExchangeRate: 0,
      lastChangeDateTime: new Date(),
      lastChangeUserId: +this.userId,
    };
    this.service.SalesInvLines = [];
  }

  AddOrEditInvoiceLine(invoiceLineIndex, invoiceNo) {
    if (!this.isPosted()) {
      const dialogConfig = new MatDialogConfig();
      dialogConfig.autoFocus = true;
      dialogConfig.disableClose = false;
      dialogConfig.width = '50%';
      dialogConfig.data = { invoiceLineIndex, invoiceNo };
      this.dialog.open(InvoiceLinesComponent, dialogConfig).afterClosed().subscribe(res => {
        this.updateGrandTotal();
      });
    }
  }


  onDeleteInvoiceLine(invoiceLineID: number, i: number) {
    if (!this.isPosted()) {
      if (invoiceLineID != null) {
        this.service.formData.deletedInvoiceLineIds += invoiceLineID + ',';
      }
      this.service.SalesInvLines.splice(i, 1);
      this.updateGrandTotal();
    }
  }

  updateGrandTotal() {
    this.service.formData.totalAmount = this.service.SalesInvLines.reduce((prev, curr) => {
      return prev + curr.lineAmount;
    }, 0);
    this.service.formData.totalAmount = parseFloat(this.service.formData.totalAmount.toFixed(2));
    this.service.formData.totalAmountLocal = this.service.formData.totalAmount;
    this.service.formData.calculatonExchangeRate = this.currExchange.exchangeRateAmount;
    if (this.service.formData.currencyId > 1) {
      if (this.currExchange.exchangeRateAmount !== 0) {
      this.service.formData.totalAmountLocal =
        parseFloat((this.service.formData.totalAmount * this.currExchange.exchangeRateAmount).toFixed(2));
        this.service.formData.calculatonExchangeRate = this.currExchange.exchangeRateAmount;
      }
    }
  }
  isPosted() {
    return (this.isPostedInvoice && this.isAdmin === 'false');
  }
  isCreditMemo() {
    return  (this.isCreditMemoInvoice && this.isAdmin === 'false');
  }

  validateForm() {
    this.isValid = true;
    if (this.service.formData.customerId === 0) {
      this.isValid = false;
    } else if (this.service.SalesInvLines.length === 0) {
      this.isValid = false;
         }
    return this.isValid;
  }

  public setDate(dateToModify: Date): Date {
    const chosenDate = new Date(dateToModify);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  onSubmit(form: NgForm) {
    if (this.validateForm()) {
      this.service.saveOrUpdateInvoice().subscribe(res => {
        // this.resetForm();
        this.toastr.success('Uspešno snimljeno.', 'Atomic Sped.');
        // this.router.navigate(['/sales/SalesInvoices']);
      },
      (error => {
        this.errorService.dialogConfig = { ...this.dialogConfig};
        this.errorService.handleError(error);
      })
      );
    } else {
      alert('Proverite obavezna polja na formi.');
    }
  }
  test(value) {
    console.log(value);
  }

  selectCurrencyChangeHandler(event: any) {
    if (typeof (this.service.formData.calculatonExchangeRate) !== 'undefined') {
    this.service.formData.calculatonExchangeRate = this.currExchange.exchangeRateAmount;
    }
    if (this.service.formData.currencyId === 1) {
      this.service.formData.taxLawText = this.TaxLawLongTextSerbian;
    } else {
      this.service.formData.taxLawText = this.TaxLawLongTextEnglish;
    }
  }
  onPrintInvoice() {
    // this.printService
    //   .printDocument('invoice', this.invoiceIdForPrint);
    const pathurl = `/sales/details/${this.invoiceIdForPrint}/print`;
    this.router.navigate([pathurl]);
  }
  onPrintInoInvoice() {
    const pathurl = `/sales/details/${this.invoiceIdForPrint}/inoprint`;
    this.router.navigate([pathurl]);
  }

}
