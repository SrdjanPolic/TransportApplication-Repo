import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { Customer } from '../../_interface/customer.model';

@Component({
  selector: 'app-customer-delete',
  templateUrl: './customer-delete.component.html',
  styleUrls: ['./customer-delete.component.css']
})
export class CustomerDeleteComponent implements OnInit {

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
    private activeRoute: ActivatedRoute) { }

    private dialogConfig;
    public customer: Customer;

  ngOnInit() {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getCustomerById();
  }

  public onCancel = () => {
    this.location.back();
  }

  private getCustomerById = () => {
    let customerId: string = this.activeRoute.snapshot.params['id'];
      
    let customerByIdUrl: string = `api/Customers/${customerId}`;
   
    this.repository.getData(customerByIdUrl)
      .subscribe(res => {
        this.customer = res as Customer;
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public deleteCustomer = () => {
    let deleteUrl: string = `api/Customers/${this.customer.id}`;
    this.repository.delete(deleteUrl)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);
        
        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

}
