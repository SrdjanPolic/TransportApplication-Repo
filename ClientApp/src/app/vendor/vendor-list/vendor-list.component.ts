import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { Vendor } from '../../_interface/vendor.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-vendor-list',
  templateUrl: './vendor-list.component.html',
  styleUrls: ['./vendor-list.component.css']
})
export class VendorListComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['name', 'vatNumber' , 'address', 'city', 'country', 'lastChangeDate', 'isInactive' , 'update'];
  public dataSource = new MatTableDataSource<Vendor>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router) { }

  ngOnInit() {
    this.getAllVendors();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  public getAllVendors = () => {
    this.repoService.getData('api/Vendors')
    .subscribe(res => {
      this.dataSource.data = res as Vendor[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/Vendors/${id}`;
    this.router.navigate([url]);
  }

  public redirectToUpdate = (id: string) => {
    let url: string = `/vendor/update/${id}`;
    this.router.navigate([url]);
  }

  public redirectToDelete = (id: string) => {
    let url: string = `/vendor/delete/${id}`;
    this.router.navigate([url]);
  }
}
