import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { CustomerForCreation } from '../../_interface/customerForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';

@Component({
  selector: 'app-customer-create',
  templateUrl: './customer-create.component.html',
  styleUrls: ['./customer-create.component.css']
})
export class CustomerCreateComponent implements OnInit {
  public customerForm: FormGroup;
  private dialogConfig;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    this.customerForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      city: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      country: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      phoneNo: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      eMail: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      vatGroup: new FormControl(0, [Validators.required, Validators.maxLength(40)]),
      isActive: new FormControl(true)
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.customerForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  public createCustomer = (customerFormValue) => {
    if (this.customerForm.valid) {
      this.executeCustomerCreation(customerFormValue);
    }
  }

  private executeCustomerCreation = (customerFormValue) => {
    let customer: CustomerForCreation = {
      name: customerFormValue.name,
      address: customerFormValue.address,
      city: customerFormValue.city,
      country: customerFormValue.country,
      phoneNo: customerFormValue.phoneNo,
      eMail : customerFormValue.eMail,
      vatGroup: customerFormValue.vatGroup,
      isActive: customerFormValue.isActive
    }

    let apiUrl = 'api/Customers';
    this.repository.create(apiUrl, customer)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);

        //we are subscribing on the [mat-dialog-close] attribute as soon as we click on the dialog button
        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
        (error => {
          this.errorService.dialogConfig = { ...this.dialogConfig };
          this.errorService.handleError(error);
        })
      )
  }

}
