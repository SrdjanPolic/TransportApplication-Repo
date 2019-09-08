import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { SalesInvService } from '../../shared/SalesInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RepositoryService} from './../../shared/repository.service';
import { SalesInvHeader} from './../../_interface/SalesInvHeader.model';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Customer} from './../../_interface/customer.model';


@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styles: ['./invoices.component.css']
})
export class InvoicesComponent implements OnInit {
  public displayedColumns = ['invoiceNo', 'postingDate' , 'customerId', 'totalAmount', 'currencyId', 'paid', 'update'];
  SalesList: Customer;
  public dataSource = new MatTableDataSource<SalesInvHeader>();
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  constructor(private service: SalesInvService,
    private Reposervice: RepositoryService,
    private errorService: ErrorHandlerService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.refreshList();
  }

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  public refreshList = () => {
    this.Reposervice.getData('api/SalesInvoiceHeaders')
    .subscribe(res => {
      this.dataSource.data = res as SalesInvHeader[];
    },
    (error) => {
      this.errorService.handleError(error);
    })

  }

public doFilter = (value: string) => {
  this.dataSource.filter = value.trim().toLocaleLowerCase();
}

public redirectToUpdate = (id: string) => {
  let url: string = `/sales/update/${id}`;
  this.router.navigate([url]);
}

public redirectToDelete = (id: string) => {
  let url: string = `/sales/delete/${id}`;
  this.router.navigate([url]);
}

public redirectToDetails = (id: string) => {
  let url: string = `/sales/details/${id}`;
  this.router.navigate([url]);
}

openForEdit(invoiceID: number) {
  let url: string = `/sales/update/${invoiceID}`;
  this.router.navigate([url]);
}

  onInvoiceDelete(id: number) {
    if (confirm('Želite li da obrišete ovaj zapis?')) {
      this.service.deleteInvoice(id).then(res => {
        this.refreshList();
        this.toastr.warning("Uspešno obrisano.", "Atomic Sped.");
      });
    }
  }

}
