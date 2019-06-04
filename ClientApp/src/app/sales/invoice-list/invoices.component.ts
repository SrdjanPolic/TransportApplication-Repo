import { Component, OnInit } from '@angular/core';
import { SalesInvService } from '../../shared/SalesInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styles: []
})
export class InvoicesComponent implements OnInit {
  SalesInvList;

  constructor(private service: SalesInvService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.refreshList();
  }

  refreshList() {
    this.service.getInvoiceList().then(res => this.SalesInvList = res);
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
