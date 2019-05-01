import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import {Customer} from '../../_interface/customer.model';


@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {
  public displayedColumns: ['name', 'address', 'city', 'country', 'details', 'update', 'delete'];
  public dataSource = new MatTableDataSource<Customer>();
  constructor(private repoService: RepositoryService) { }

  ngOnInit() {
    this.getAllCustomers();
    console.log(this.dataSource);
  }
 
  public getAllCustomers = () => {
    this.repoService.getData('api/Customers')
    .subscribe( res => {
      this.dataSource.data = res as Customer[];
    });
  }
  public redirectToDetails = (id: string) => {
    
  }
 
  public redirectToUpdate = (id: string) => {
    
  }
 
  public redirectToDelete = (id: string) => {
    
  }
}
