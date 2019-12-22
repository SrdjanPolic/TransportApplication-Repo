import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material";
import { SalesInvLine } from '../../_interface/SalesInvLine.model';
//import { ItemService } from 'src/app/shared/item.service';
//import { Item } from 'src/app/shared/item.model';
import { NgForm } from '@angular/forms';
import { SalesInvService } from '../../shared/SalesInv.service';

@Component({
  selector: 'app-invoice-lines',
  templateUrl: './invoice-lines.component.html',
  styles: []
})
export class InvoiceLinesComponent implements OnInit {
  formData: SalesInvLine;
  //itemList: Item[];
  isValid: boolean = true;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<InvoiceLinesComponent>,
    //private itemService: ItemService,
    private invoiceService: SalesInvService) { }

  ngOnInit() {
    //this.itemService.getItemList().then(res => this.itemList = res as Item[]);
    let newDt = new Date();
    if (this.data.invoiceLineIndex == null)
      this.formData = {
        id: 0,
        loadDate: newDt,
        unloadDate: newDt,
        loadAddress: '',
        unloadAddress: '',
        exportCustoms: '',
        importCustoms: '',
        quantity: 0,
        unitPrice: 0,
        discountPercent: 0,
        lineAmount: 0,
        remark: '',
        description: '',
        vatPercent: 0,
        salesHeaderId: 0,
      }
    else
      this.formData = Object.assign({}, this.invoiceService.SalesInvLines[this.data.invoiceLineIndex]);
  }

  // updatePrice(ctrl) {
  //   if (ctrl.selectedIndex == 0) {
  //     this.formData.Price = 0;
  //     this.formData.ItemName = '';
  //   }
  //   else {
  //     this.formData.Price = this.itemList[ctrl.selectedIndex - 1].Price;
  //     this.formData.ItemName = this.itemList[ctrl.selectedIndex - 1].Name;
  //   }
  //   this.updateTotal();
  // }

  updateTotal() {
    this.formData.lineAmount = parseFloat((this.formData.quantity * (this.formData.unitPrice - this.formData.unitPrice *(this.formData.discountPercent/100))*(1 + this.formData.vatPercent/100)).toFixed(2));
  }

  onSubmit(form: NgForm) {
    if (this.validateForm(form.value)) {
      if (this.data.invoiceLineIndex == null)
        this.invoiceService.SalesInvLines.push(form.value);
      else
      this.invoiceService.SalesInvLines[this.data.invoiceLineIndex] = form.value;
      this.dialogRef.close();
    }
  }

  validateForm(formData: SalesInvLine) {
    this.isValid = true;
    if (formData.unitPrice == 0)
      this.isValid = false;
    else if (formData.quantity == 0)
      this.isValid = false;
    return this.isValid;
  }

}
