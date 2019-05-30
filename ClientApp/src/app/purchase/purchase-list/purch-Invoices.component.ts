import { Component, OnInit } from '@angular/core';
import { PurchInvService } from '../../shared/PurchInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-purch-Invoices',
  templateUrl: './purchInvoices.component.html',
  styles: []
})
export class PurchInvoicesComponent implements OnInit {
  PurchInvList;

  constructor(private service: PurchInvService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.refreshList();
  }

  refreshList() {
    this.service.getOrderList().then(res => this.PurchInvList = res);
  }

  openForEdit(orderID: number) {
    this.router.navigate(['/order/edit/' + orderID]);
  }

  onInvoiceDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteOrder(id).then(res => {
        this.refreshList();
        this.toastr.warning("Deleted Successfully", "Atomic Sped.");
      });
    }
  }

}
