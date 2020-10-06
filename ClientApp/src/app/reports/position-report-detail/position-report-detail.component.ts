import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { PositionReportDetail } from '../../_interface/positionReportDetail.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-position-report-detail',
  templateUrl: './position-report-detail.component.html',
  styleUrls: ['./position-report-detail.component.css']
})
export class PositionReportDetailComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['criteria', 'revenue', 'expences', 'profit', 'details'];
  public dataSource = new MatTableDataSource<PositionReportDetail>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router) { }

  ngOnInit() {
    this.getAllDocs();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  public getAllDocs = () => {
    this.repoService.getData('api/Reports/GetExternalReferenceProfitReport')
    .subscribe(res => {
      this.dataSource.data = res as PositionReportDetail[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
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
}
