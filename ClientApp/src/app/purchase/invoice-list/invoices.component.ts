import { Component, OnInit, AfterViewInit,ViewChild } from '@angular/core';
import { PurchInvService } from '../../shared/PurchInv.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import {RepositoryService} from './../../shared/repository.service';
import {PurchInvHeader} from './../../_interface/PurchInvHeader.model';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import {Vendor} from './../../_interface/vendor.model';


@Component({
  selector: 'app-invoices',
  templateUrl: './invoices.component.html',
  styleUrls: ['./invoices.component.css']
})
export class InvoicesComponent implements OnInit, AfterViewInit {
  public displayedColumns = ['invoiceNo', 'postingDate' , 'vendorId', 'totalAmount', 'totalAmountLocal' , 'currencyId', 'paid', 'update'];
  vendorList: Vendor;
  public dataSource = new MatTableDataSource<PurchInvHeader>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  constructor(private service: PurchInvService,
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
    this.Reposervice.getData('api/PurchaseInvoiceHeaders')
    .subscribe(res => {
      this.dataSource.data = res as PurchInvHeader[];
    },
    (error) => {
      this.errorService.handleError(error);
    })

  }
  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public redirectToUpdate = (id: string) => {
    let url: string = `/purchase/update/${id}`;
    this.router.navigate([url]);
  }

  public redirectToDelete = (id: string) => {
    let url: string = `/purchase/delete/${id}`;
    this.router.navigate([url]);
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/purchase/details/${id}`;
    this.router.navigate([url]);
  }


  openForEdit(invoiceID: number) {
    let url: string = `/purchase/update/${invoiceID}`;
    this.router.navigate([url]);
  }

  onInvoiceDelete(id: number) {
    if (confirm('Želite li da obrišete ovaj zapis?')) {
      this.service.deleteInvoice(id).then(res => {
        this.refreshList();
        this.toastr.warning('Uspešno obrisano.', "Atomic Sped.");
      });
    }
  }

}
