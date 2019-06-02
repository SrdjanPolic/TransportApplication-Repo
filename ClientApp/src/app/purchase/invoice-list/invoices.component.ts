import { Component, OnInit } from '@angular/core';
import { PurchInvService } from '../../shared/PurchInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styles: []
})
export class InvoicesComponent implements OnInit {
  PurchInvList;

  constructor(private service: PurchInvService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.refreshList();
  }

  refreshList() {
    this.service.getInvoiceList().then(res => this.PurchInvList = res);
  }

  openForEdit(invoiceID: number) {
    this.router.navigate(['/invoice/edit/' + invoiceID]);
  }

  onInvoiceDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteInvoice(id).then(res => {
        this.refreshList();
        this.toastr.warning("Deleted Successfully", "Atomic Sped.");
      });
    }
  }

}
