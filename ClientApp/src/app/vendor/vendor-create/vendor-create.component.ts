import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { VendorForCreation } from '../../_interface/vendorForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';

@Component({
  selector: 'app-vendor-create',
  templateUrl: './vendor-create.component.html',
  styleUrls: ['./vendor-create.component.css']
})
export class VendorCreateComponent implements OnInit {
  public vendorForm: FormGroup;
  private dialogConfig;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    this.vendorForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      city: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      country: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      phoneNo: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      eMail: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      paymentTermsCode: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      vatGroup: new FormControl(0, [Validators.required, Validators.maxLength(40)]),
      vatNumber: new FormControl('', [Validators.required, Validators.maxLength(50)]),
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
    return this.vendorForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  public createVendor = (vendorFormValue) => {
    if (this.vendorForm.valid) {
      this.executeVendorCreation(vendorFormValue);
    }
  }

  private executeVendorCreation = (vendorFormValue) => {
    let vendor: VendorForCreation = {
      name: vendorFormValue.name,
      address: vendorFormValue.address,
      city: vendorFormValue.city,
      country: vendorFormValue.country,
      phoneNo: vendorFormValue.phoneNo,
      eMail : vendorFormValue.eMail,
      paymentTermsCode : vendorFormValue.paymentTermsCode,
      vatGroup: vendorFormValue.vatGroup,
      vatNumber: vendorFormValue.vatNumber,
      isInactive: vendorFormValue.isInactive,
      lastChangeDate: vendorFormValue.lastChangeDate
    }

    let apiUrl = 'api/Vendors';
    this.repository.create(apiUrl, vendor)
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
