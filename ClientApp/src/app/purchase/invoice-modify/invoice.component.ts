import { PurchInvService } from './../../shared/PurchInv.service';
import {RepositoryService} from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { InvoiceLinesComponent } from '../../purchase/invoice-lines/invoice-lines.component';
import { Vendor } from '../../_interface/vendor.model';
import {Currency} from '../../_interface/Currency.model';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import {MaterialModule} from './../../material/material.module';
import { Settings } from 'src/app/_interface/Settings.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import {CurrencyExchange} from '../../_interface/currencyExchange.model';
import * as moment from 'moment';


@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styles: []
})
export class InvoiceComponent implements OnInit {
  vendorList: Vendor[];
  isValid: boolean = true;
  currencyList: Currency[];
  currExchange: CurrencyExchange;
  settings: Settings;
  invoiceNumber: string;
  private dialogConfig;
  isPostedInvoice: boolean;
  isCreditMemoInvoice: boolean;
  public response: { dbPath: ''};
  imgPath: string;

  constructor(public service: PurchInvService,
    private dialog: MatDialog,
    private repoService: RepositoryService,
    private toastr: ToastrService,
    private router: Router,
    private errorService: ErrorHandlerService,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    const invoiceID = this.currentRoute.snapshot.paramMap.get('id');
    this.repoService.getData('api/Vendors').subscribe(res => this.vendorList = res as Vendor[]);
    this.repoService.getData('api/Currency').subscribe(res => this.currencyList = res as Currency[]);

    if (invoiceID == null) {
      this.resetForm();
      } else {
      this.service.getInvoiceByID(parseInt(invoiceID)).then(res => {
        this.service.formData = res;
        this.service.PurchInvLines = res.lines;
        this.service.formData.deletedInvoiceLineIds = '';
        this.isPostedInvoice = res.invoiced;
        this.isCreditMemoInvoice = res.creditMemo;
        this.service.formData.lastChangeUserId = +this.userId;
      });
    }
  }

  get userId(): string {
    return localStorage.getItem('userId');
  }

  get isAdmin(): string {
    return localStorage.getItem('isAdmin');
  }

  isPosted() {
    return (this.isPostedInvoice && this.isAdmin === 'false');
  }
  isCreditMemo() {
    return  (this.isCreditMemoInvoice && this.isAdmin === 'false');
  }

  resetForm(form?: NgForm) {
  let newDt = new Date();
    if (form = null) {
      form.resetForm();
    }
  this.service.formData = {
    id: 0,
    invoiceNo: 'Biće automatski dodeljen',  //will be delt on back end
    postingDate: new Date(),
    supplierInvoiceNo: '',
    externalReferenceNo: '',
    dueDate: new Date(newDt.setDate(newDt.getDate() + 14)),
    totalAmount: 0,
    paid: false,
    invoiced: false,
    creditMemo: false,
    paymentDate: new Date(newDt.setDate(newDt.getDate() + 14)),
    currencyId: 0,
    vendorId: 0,
    currency: '',
    deletedInvoiceLineIds: '',
    lastChangeDateTime: new Date(),
    totalAmountLocal: 0,
    vendorName : '',
    lastChangeUserId: +this.userId,
  };
  this.service.PurchInvLines = [];
}

  AddOrEditInvoiceLine(invoiceLineIndex, invoiceNo) {
    if (!this.isPosted()) {
      const dialogConfig = new MatDialogConfig();
      dialogConfig.autoFocus = true;
      dialogConfig.disableClose = true;
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
      this.service.PurchInvLines.splice(i, 1);
      this.updateGrandTotal();
    }
  }

  updateGrandTotal() {
    this.service.formData.totalAmount = this.service.PurchInvLines.reduce((prev, curr) => {
      return prev + curr.lineAmount;
    }, 0);
    this.service.formData.totalAmount = parseFloat(this.service.formData.totalAmount.toFixed(2));
    this.service.formData.totalAmountLocal = this.service.formData.totalAmount;
    if (this.service.formData.currencyId > 1) {
      if (this.currExchange.exchangeRateAmount !== 0) {
      this.service.formData.totalAmountLocal =
        parseFloat((this.service.formData.totalAmount * this.currExchange.exchangeRateAmount).toFixed(2));
      }
    }
  }

  validateForm() {
    this.isValid = true;
    if (this.service.formData.vendorId === 0) {
      this.isValid = false;
    } else if (this.service.PurchInvLines.length === 0) {
      this.isValid = false;
         }
    return this.isValid;
  }

  onSubmit(form: NgForm) {
    if (this.validateForm()) {
      this.service.saveOrUpdateInvoice().subscribe(res => {
        this.resetForm();
        this.toastr.success('Uspešno snimljeno.', 'Atomic Sped.');
        this.router.navigate(['/purchase/PurchInvoices']);
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

  async getDataFromService () {
    await this.repoService.getData('api/Settings/PurchaseInvoice').subscribe(res => {
      this.settings = res as Settings;
      console.log(this.settings);
    });
  }

  adjustDateForTimeOffset(dateToAdjust: Date) {
    dateToAdjust.setHours(dateToAdjust.getHours() + 2);
    return dateToAdjust;
    }

  selectCurrencyChangeHandler(event: any) {
    const currid = '2';
    const postingDate2 = moment(this.service.formData.postingDate).format('YYYY.MM.DD');
    const apiUrl2 = `api/ExchangeRate/${currid}/${postingDate2}`;
    this.repoService.getData(apiUrl2).subscribe(res2 => {
      this.currExchange = res2 as CurrencyExchange;
    });
  }
  selectPaymentDataHandler(event: any) {
    const currid = '2';
    const postingDate2 = moment(this.service.formData.postingDate).format('YYYY.MM.DD');
    const apiUrl2 = `api/ExchangeRate/${currid}/${postingDate2}`;
    this.repoService.getData(apiUrl2).subscribe(res2 => {
      this.currExchange = res2 as CurrencyExchange;
    });
    }

    public uploadFinished = (event) => {
      this.response = event;
      this.imgPath = this.response.dbPath;
    }
    public createImgPath = (serverPath: string) => {
      const apiUrl = ``;
      return this.repoService.getData(serverPath);
    }


}
