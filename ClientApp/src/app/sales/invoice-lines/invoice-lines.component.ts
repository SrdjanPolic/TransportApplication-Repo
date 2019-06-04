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
    if (this.data.invoiceLineIndex == null)
      this.formData = {
        id: null,
        UnitPrice: 0,
        Quantity: 0,
        DiscountPercent: 0,
        LineAmount: 0,
        Remark: '',
        Description: '',
        VatPercent: 0,
        SalesInvHeaderid: this.data.SalesInvHeaderid,
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
    this.formData.LineAmount = parseFloat((this.formData.Quantity * (this.formData.UnitPrice - this.formData.UnitPrice *(this.formData.DiscountPercent/100))*(1 + this.formData.VatPercent/100)).toFixed(2));
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
    if (formData.UnitPrice == 0)
      this.isValid = false;
    else if (formData.Quantity == 0)
      this.isValid = false;
    return this.isValid;
  }

}
