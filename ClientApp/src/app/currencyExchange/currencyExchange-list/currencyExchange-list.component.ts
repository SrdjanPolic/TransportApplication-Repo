import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { CurrencyExchange } from '../../_interface/currencyExchange.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-currencyExchange-list',
  templateUrl: './currencyExchange-list.component.html',
  styleUrls: ['./currencyExchange-list.component.css']
})
export class CurrencyExchangeListComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['currencyId', 'startingDate', 'exchangeRateAmount', 'update'];
  public dataSource = new MatTableDataSource<CurrencyExchange>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router) { }

  ngOnInit() {
    this.getAllCurrencyExchange();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  public getAllCurrencyExchange = () => {
    this.repoService.getData('api/ExchangeRate/GetExchangeRatesForCurrency/2')
    .subscribe(res => {
      this.dataSource.data = res as CurrencyExchange[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/ExchangeRate/${id}`;
    this.router.navigate([url]);
  }

  public redirectToUpdate = (id: string) => {
    window.alert('U izradi');
    // let url: string = `/ExchangeRate/update/${id}`;
    // this.router.navigate([url]);
  }
}
