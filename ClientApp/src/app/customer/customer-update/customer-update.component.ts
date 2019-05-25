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
  selector: 'app-customer-update',
  templateUrl: './customer-update.component.html',
  styleUrls: ['./customer-update.component.css']
})
export class CustomerUpdateComponent implements OnInit {

  public customerForm: FormGroup;
  private dialogConfig;
  public customer: Customer;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    this.customerForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      city: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      country: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      phoneNo: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      email: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      vatGroup: new FormControl(0, [Validators.required, Validators.maxLength(40)]),
      vatNumber: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      isInactive: new FormControl(true)
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getCustomerById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.customerForm.controls[controlName].hasError(errorName);
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
        this.customerForm.patchValue(this.customer);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateCustomer = (customerFormValue) => {
    if (this.customerForm.valid) {
      this.executeCustomerUpdate(customerFormValue);
    }
  }

  private executeCustomerUpdate = (customerFormValue) => {
 
    this.customer.name = customerFormValue.name;
    this.customer.address = customerFormValue.address;
    this.customer.city = customerFormValue.city;
    this.customer.country = customerFormValue.country;
    this.customer.phoneNo = customerFormValue.phoneNo;
    this.customer.email = customerFormValue.email;
    this.customer.vatGroup = customerFormValue.vatGroup;
    this.customer.vatNumber = customerFormValue.vatNumber;
    this.customer.isInactive = customerFormValue.isInactive;
   
    let apiUrl = `api/Customers/${this.customer.id}`;
    this.repository.update(apiUrl, this.customer)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);
        
        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
      (error => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
    )
  }

}
