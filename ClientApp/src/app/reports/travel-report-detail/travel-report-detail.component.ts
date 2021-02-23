import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { ProfitReportDetail } from '../../_interface/profitReportDetail.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-travel-report-detail',
  templateUrl: './travel-report-detail.component.html',
  styleUrls: ['./travel-report-detail.component.css']
})
export class TravelReportDetailComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['travelOrderNo', 'partner', 'input', 'output', 'documentNo', 'salesPerson' , 'invoiceDate'];
  public dataSource = new MatTableDataSource<ProfitReportDetail>();
  private dialogConfig;

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private repository: RepositoryService, private errorService: ErrorHandlerService,
    private router: Router, private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    this.getDocumentById();
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  private getDocumentById = () => {
    let documentId: string = this.activeRoute.snapshot.params['id'] + '/' + this.activeRoute.snapshot.params['id2'];

    let documentByIdUrl: string = `api/Reports/GetTravelOrderProfitReportItems/${documentId}`;

    this.repository.getData(documentByIdUrl)
      .subscribe(res => {
        this.dataSource.data = res as ProfitReportDetail[];
        //this.customerForm.patchValue(this.customer);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      });
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public getTotalRevenue() {
    return this.dataSource.data.map(t => t.input).reduce((acc, input) => acc + input, 0);
  }
  public getTotalExpences() {
    return this.dataSource.data.map(t => t.output).reduce((acc, output) => acc + output, 0);
  }
  public getTotalProfit() {
    return this.dataSource.data.map(t => t.input).reduce((acc, input) => acc + input, 0);
  }
}
