import {CustomerComponent} from './../customer/customer.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { CustomerService } from '../../shared/customer.service';
import {MatTableDataSource, MatSort, MatPaginator} from '@angular/material';
import {MatDialog, MatDialogConfig} from '@angular/material';
import { NotificationService } from 'src/app/shared/notification.service';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  constructor(private service: CustomerService,
              private dialog: MatDialog,
              private notificationService: NotificationService) { }

  listData: MatTableDataSource<any>;
  displayedColumns: string[] = ['Name', 'City', 'Country', 'VATNumber', 'Disabled', 'actions'];
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchKey: string;

  ngOnInit() {
    this.service.getCustomers().subscribe(
      list => {
        let array = list.map(item => {
          return {
            $key: item.key,
            ...item.payload.val()
          };
        });
        this.listData = new MatTableDataSource(array);
        this.listData.sort = this.sort;
        this.listData.paginator = this.paginator;
        this.listData.filterPredicate = (data, filter) => {
          return this.displayedColumns.some( ele => {
            return ele != 'actions' && data[ele].toLowerCase().indexOf(filter) != -1;

          });
        };
      });
  }

  onSearchClear() {
    this.searchKey = "";
    this.applyFilter();
  }

  applyFilter() {
    this.listData.filter = this.searchKey.trim().toLowerCase();
  }

  onCreate() {
    this.service.initializeFormGroup();
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "80%";
    this.dialog.open(CustomerComponent, dialogConfig);
  }

  onEdit(row) {
    this.service.populateForm(row); 
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "80%";
    this.dialog.open(CustomerComponent, dialogConfig);
  }
  
  onDelete($key) {
    if (confirm('Želite li da obrišete podatak?')) {
    this.service.deleteCustomer($key);
    this.notificationService.warn('! Brisanje uspešno');
    }  
  }
}
