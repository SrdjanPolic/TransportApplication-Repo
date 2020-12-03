import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { ProfitReport } from '../../_interface/profitReport.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-travel-report',
  templateUrl: './travel-report.component.html',
  styleUrls: ['./travel-report.component.css']
})
export class TravelReportComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['criteria', 'revenue', 'expences', 'profit', 'details'];
  public dataSource = new MatTableDataSource<ProfitReport>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild('TABLE') table: ElementRef;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router) { }

  ngOnInit() {
    this.getAllDocs();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  public getAllDocs = () => {
    this.repoService.getData('api/Reports/GetTravelOrderProfitReport')
    .subscribe(res => {
      this.dataSource.data = res as ProfitReport[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/reports/TravelReport/${id}`;
    this.goToLink(url);
    // this.router.navigate([url]);
  }
  public goToLink(url: string) {
    window.open(url, '_blank');
  }

  public getTotalRevenue() {
    return this.dataSource.data.map(t => t.revenue).reduce((acc, revenue) => acc + revenue, 0);
  }
  public getTotalExpences() {
    return this.dataSource.data.map(t => t.expences).reduce((acc, expences) => acc + expences, 0);
  }
  public getTotalProfit() {
    return this.dataSource.data.map(t => t.profit).reduce((acc, profit) => acc + profit, 0);
  }

  exportAsExcel() {
    const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(this.table.nativeElement); // convert DOM TABLE element to a worksheet
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

    /* save to file */
    XLSX.writeFile(wb, 'TravelReport.xlsx');

  }
}
