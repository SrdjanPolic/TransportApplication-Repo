//import { CustomerService } from './../../shared/customer.service';
import { PurchInvService } from './../../shared/PurchInv.service';
import {RepositoryService} from './../../shared/repository.service';
//import { OrderService } from './../../shared/order.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { InvoiceLinesComponent } from '../../purchase/invoice-lines/invoice-lines.component';
import { Vendor } from '../../_interface/vendor.model';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';


@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styles: []
})
export class InvoiceComponent implements OnInit {
  vendorList: Vendor[];
  isValid: boolean = true;

  constructor(private service: PurchInvService,
    private dialog: MatDialog,
    private repoService: RepositoryService,
    private toastr: ToastrService,
    private router: Router,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    let invoiceID = this.currentRoute.snapshot.paramMap.get('id');
    if (invoiceID == null)
      this.resetForm();
    else {
      this.service.getInvoiceByID(parseInt(invoiceID)).then(res => {
        this.service.formData = res;
        this.service.PurchInvLines = res.lines;
      });
    }

    this.repoService.getData('api/Vendors').subscribe(res => this.vendorList = res as Vendor[]);
  }

  resetForm(form?: NgForm) {
    let newDt = new Date();
    if (form = null)
      form.resetForm();
    this.service.formData = {
      id: 0,
      invoiceNo: (environment.PurchInvoiceNo + '-' + environment.lastUsedNo).toString(),
      postingDate: newDt,
      externalReferenceNo: '',
      dueDate: new Date(newDt.setDate(newDt.getDate() + 14)),
      totalAmount: 0,
      paid: false,
      invoiced: false,
      creditMemo: false,
      paymentDate: new Date(),
      currencyId: 0,
      vendorId: 0,
      currency: '',
      deletedPurchInvLineIDs: ''
    };
    this.service.PurchInvLines = [];
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
      this.service.formData.deletedPurchInvLineIDs += invoiceLineID + ",";
    this.service.PurchInvLines.splice(i, 1);
    this.updateGrandTotal();
  }

  updateGrandTotal() {
    this.service.formData.totalAmount = this.service.PurchInvLines.reduce((prev, curr) => {
      return prev + curr.lineAmount;
    }, 0);
    this.service.formData.totalAmount = parseFloat(this.service.formData.totalAmount.toFixed(2));
  }

  validateForm() {
    this.isValid = true;
    if (this.service.formData.vendorId == 0)
      this.isValid = false;
    else if (this.service.PurchInvLines.length == 0)
      this.isValid = false;
    return this.isValid;
  }


  onSubmit(form: NgForm) {
    
    if (this.validateForm()) {
      this.service.saveOrUpdateInvoice().subscribe(res => {
        if (this.service.formData.id != 0){
          environment.lastUsedNo += 1;}
        this.resetForm();
        this.toastr.success('Submitted Successfully', 'Atomic Sped.');
        this.router.navigate(['/purchase/PurchInvoices']);
      })
    }
  }

}