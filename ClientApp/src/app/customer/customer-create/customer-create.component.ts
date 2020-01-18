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
      country: new FormControl('', [Validators.required, Validators.pattern('[A-Z]{2}')]),
      phoneNo: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      email: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      vatGroup: new FormControl(0, [Validators.required, Validators.maxLength(40)]),
      vatNumber: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      personalIdNumber: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      isInactive: new FormControl(false)
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

  get userId(): string {
    return localStorage.getItem('userId');
  }

  public createCustomer = (customerFormValue) => {
    if (this.customerForm.valid) {
      this.executeCustomerCreation(customerFormValue);
    }
  }

  public setDate(control: string): Date {
    const chosenDate = new Date(this.customerForm.get(control).value);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  private executeCustomerCreation = (customerFormValue) => {
    const currentdate = new Date().toLocaleString();
    let customer: CustomerForCreation = {
      name: customerFormValue.name,
      address: customerFormValue.address,
      city: customerFormValue.city,
      country: customerFormValue.country,
      phoneNo: customerFormValue.phoneNo,
      email : customerFormValue.email,
      vatGroup: customerFormValue.vatGroup,
      vatNumber: customerFormValue.vatNumber,
      isInactive: customerFormValue.isInactive,
      personalIdNumber: customerFormValue.personalIdNumber,
      lastChangeDateTime: currentdate,
      lastChangeUserId: +this.userId,
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
