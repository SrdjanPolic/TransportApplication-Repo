import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { SalesInvService } from '../../shared/SalesInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RepositoryService} from './../../shared/repository.service';
import { SalesInvHeader} from './../../_interface/SalesInvHeader.model';
import { MatSort, MatPaginator } from '@angular/material';
import { MatTableDataSource} from '@angular/material/table';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Customer} from './../../_interface/customer.model';


@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styles: ['./invoices.component.css']
})
export class InvoicesComponent implements OnInit, AfterViewInit {
  public displayedColumns = ['invoiceNo', 'postingDate' , 'customerId', 'totalAmount', 'currencyId',
   'paid', 'invoiced', 'creditMemo', 'update'];
  SalesList: Customer;
  public dataSource = new MatTableDataSource<SalesInvHeader>();
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  Filter: string;
  filterValues = {
    paid: 'false',
    invoiced: 'false',
    creditMemo: 'false',
  };
  constructor(private service: SalesInvService,
    private Reposervice: RepositoryService,
    private errorService: ErrorHandlerService,
    private router: Router,
    private toastr: ToastrService) {
     }

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
public filterBy = (value: string) => {
  switch(value) {
    case 'paid':
      this.filterValues.paid = 'true';
      this.filterValues.invoiced = 'false';
      this.filterValues.creditMemo = 'false';
      this.dataSource.filter = JSON.stringify(this.filterValues);
      break;
    case 'invoiced':
      this.filterValues.invoiced = 'true';
      this.filterValues.paid = 'false';
      this.filterValues.creditMemo = 'false';
      this.dataSource.filter = JSON.stringify(this.filterValues);
      break;
    case 'creditMemo':
      this.filterValues.creditMemo = 'true';
      this.filterValues.paid = 'false';
      this.filterValues.invoiced = 'false';
      this.dataSource.filter = JSON.stringify(this.filterValues);
      break;
    default: break;
  }
}
public createFilter(): (data: any, filter: string) => boolean {
  let filterFunction = function(data, filter): boolean {
    let searchTerms = JSON.parse(filter);
    return data.paid.toString().toLocaleLowerCase().indexOf(searchTerms.paid) !== -1
    && data.invoiced.toString().toLocaleLowerCase().indexOf(searchTerms.invoiced) !== -1
    && data.creditMemo.toString().toLocaleLowerCase().indexOf(searchTerms.creditMemo) !== -1;
  }
  return filterFunction;
}
public clearFilters =() => {
  this.dataSource.filter = '';
  this.Filter = '';
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
