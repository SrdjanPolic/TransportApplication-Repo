import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { PurchInvLine } from '../../_interface/PurchInvLine.model';
//import { ItemService } from 'src/app/shared/item.service';
//import { Item } from 'src/app/shared/item.model';
import { NgForm } from '@angular/forms';
import { PurchInvService } from '../../shared/PurchInv.service';

@Component({
  selector: 'app-invoice-lines',
  templateUrl: './invoice-lines.component.html',
  styles: []
})
export class InvoiceLinesComponent implements OnInit {
  formData: PurchInvLine;
  //itemList: Item[];
  isValid = true;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<InvoiceLinesComponent>,
    //private itemService: ItemService,
    private invoiceService: PurchInvService) { }

  ngOnInit() {
    //this.itemService.getItemList().then(res => this.itemList = res as Item[]);
    if (this.data.invoiceLineIndex == null) {
      this.formData = {
        id: 0,
        unitPrice: 0,
        quantity: 0,
        discountPercent: 0,
        lineAmount: 0,
        remark: '',
        description: '',
        vatPercent: 0,
        purchInvHeaderid: this.data.purchInvHeaderid,
      };
    } else {
      this.formData = Object.assign({}, this.invoiceService.PurchInvLines[this.data.invoiceLineIndex]);
    }
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
    this.formData.lineAmount = parseFloat((this.formData.quantity * (this.formData.unitPrice - this.formData.unitPrice * (this.formData.discountPercent / 100)) * (1 + this.formData.vatPercent / 100)).toFixed(2));
  }

  onSubmit(form: NgForm) {
    if (this.validateForm(form.value)) {
      if (this.data.invoiceLineIndex == null) {
        this.invoiceService.PurchInvLines.push(form.value);
      }
      else {
      this.invoiceService.PurchInvLines[this.data.invoiceLineIndex] = form.value;
      }
      this.dialogRef.close();
    }
  }

  validateForm(formData: PurchInvLine) {
    this.isValid = true;
    if (formData.unitPrice === 0) {
      this.isValid = false;
    } else if (formData.quantity === 0) {
      this.isValid = false;
         }
    return this.isValid;
  }

}
