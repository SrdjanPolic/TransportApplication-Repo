//import { CustomerService } from './../../shared/customer.service';
import { SalesInvService } from './../../shared/SalesInv.service';
import { RepositoryService } from './../../shared/repository.service';
//import { OrderService } from './../../shared/order.service';
import { Component, OnInit } from '@angular/core';
import { NgForm, Validators } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { InvoiceLinesComponent } from '../../sales/invoice-lines/invoice-lines.component';
import { Customer } from '../../_interface/customer.model';
import { Currency } from '../../_interface/Currency.model';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { Settings } from 'src/app/_interface/Settings.model';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styles: []
})
export class InvoiceComponent implements OnInit {
  customerList: Customer[];
  isValid: boolean = true;
  currencyList: Currency[];
  settings: Settings;

  constructor(private service: SalesInvService,
    private dialog: MatDialog,
    private repoService: RepositoryService,
    private toastr: ToastrService,
    private router: Router,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    let invoiceID = this.currentRoute.snapshot.paramMap.get('id');
    this.repoService.getData('api/Settings/SalesInvoice').subscribe(res => { 
      this.settings = res as Settings;
      });
    if (invoiceID == null)
      this.resetForm();
    else {
      this.service.getInvoiceByID(parseInt(invoiceID)).then(res => {
        this.service.formData = res;
        this.service.SalesInvLines = res.lines;
        this.service.formData.deletedInvoiceLineIds = '';
      });
    }

    this.repoService.getData('api/Customers').subscribe(res => this.customerList = res as Customer[]);
    this.repoService.getData('api/Currency').subscribe(res => this.currencyList = res as Currency[]);
  }

  resetForm(form?: NgForm) {
    let newDt = new Date();
    if (form = null)
     form.resetForm();
    this.service.formData = {
      id: null,
      invoiceNo: (environment.SalesInvoiceNo + (environment.lastUsedNo + 1)).toString(),
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
      commoditytype: '',
      numberofPalletsPlaces: '',
      bruttoWeight: '',
      adrNeeded: false,
      remarks: '',
      vechicleRegNumber: '',
      driverName: '',
      routeDistance: 0,
      loadRepresentative: '',
      pricePerKm: 0,
      crmNumber: '',
      deletedInvoiceLineIds: '',
      currencyId: 0,
      customerId: 0,
    };
    this.service.SalesInvLines = [];
  }

  AddOrEditInvoiceLine(invoiceLineIndex, invoiceNo) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.disableClose = true;
    dialogConfig.width = "50%";
    dialogConfig.data = { invoiceLineIndex, invoiceNo };
    this.dialog.open(InvoiceLinesComponent, dialogConfig).afterClosed().subscribe(res => {
      this.updateGrandTotal();
    });
  }


  onDeleteInvoiceLine(invoiceLineID: number, i: number) {
    if (invoiceLineID != null)
      this.service.formData.deletedInvoiceLineIds += invoiceLineID + ",";
    this.service.SalesInvLines.splice(i, 1);
    this.updateGrandTotal();
  }

  updateGrandTotal() {
    this.service.formData.totalAmount = this.service.SalesInvLines.reduce((prev, curr) => {
      return prev + curr.lineAmount;
    }, 0);
    this.service.formData.totalAmount = parseFloat(this.service.formData.totalAmount.toFixed(2));
  }

  validateForm() {
    this.isValid = true;
    if (this.service.formData.customerId == 0)
      this.isValid = false;
    else if (this.service.SalesInvLines.length == 0)
      this.isValid = false;
    return this.isValid;
  }


  onSubmit(form: NgForm) {
    if (this.validateForm()) {
      this.service.saveOrUpdateInvoice().subscribe(res => {
        environment.lastUsedNo += 1;
        this.resetForm();
        this.toastr.success('Uspešno snimljeno.', 'Atomic Sped.');
        this.router.navigate(['/sales/SalesInvoices']);
      })
    }
  }
  test(value) {
    console.log(value);
  }

}
