import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild, ElementRef} from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator, MatFormField } from '@angular/material';
import { ProfitReport } from '../../_interface/profitReport.model';
import { DatumQuery} from '../../_interface/DatumQuery.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import * as XLSX from 'xlsx';
import { now } from 'moment';

@Component({
  selector: 'app-position-report',
  templateUrl: './position-report.component.html',
  styleUrls: ['./position-report.component.css']
})
export class PositionReportComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['criteria', 'revenue', 'expences', 'profit', 'details'];
  public dataSource = new MatTableDataSource<ProfitReport>();
  FromDate: Date;
  ToDate: Date;

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild('TABLE') table: ElementRef;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router,
    private http: HttpClient) { }

  ngOnInit() {
    this.getAllDocs();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }
  onInputDateFrom(event: any) {
    this.FromDate = event.target.value;
  }
  onInputDateTo(event: any) {
    this.ToDate = event.target.value;
  }

  public getAllDocs = () => {
   let DatumQueryItem: DatumQuery = {
      FromDate: this.FromDate,
      ToDate: this.ToDate
   }
    const datesToParse = JSON.stringify(DatumQueryItem);
    const routeToLogin = 'api/' + 'Reports/GetExternalReferenceProfitReport';
      this.repoService.post(routeToLogin, datesToParse)
      .subscribe(res => {
        this.dataSource.data = res as ProfitReport[];
      },
      (error) => {
        this.errorService.handleError(error);
      });
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }
  public doFilterByDate = () => {
     if ((!this.FromDate) && (!this.ToDate)) {
       window.alert('Datumi moraju biti uneti.');
     } else {
      const DatumQueryItem: DatumQuery = {
        FromDate: this.FromDate,
        ToDate: this.ToDate
     };
      const datesToParse = JSON.stringify(DatumQueryItem);
      this.dataSource.data = [];
      const routeToLogin = 'api/' + 'Reports/GetExternalReferenceProfitReport';
      this.repoService.post(routeToLogin, datesToParse)
      .subscribe(res => {
        this.dataSource.data = res as ProfitReport[];
      },
      (error) => {
        this.errorService.handleError(error);
      });
    }
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/reports/PositionReport/${id}`;
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
  exportAsExcel()
    {
      const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(this.table.nativeElement); // convert DOM TABLE element to a worksheet
      const wb: XLSX.WorkBook = XLSX.utils.book_new();
      XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

      /* save to file */
      XLSX.writeFile(wb, 'PositionReport.xlsx');

    }
}
