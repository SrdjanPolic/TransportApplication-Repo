import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { DriverForCreation } from '../../_interface/driverForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';

@Component({
  selector: 'app-driver-create',
  templateUrl: './driver-create.component.html',
  styleUrls: ['./driver-create.component.css']
})
export class DriverCreateComponent implements OnInit {
  public driverForm: FormGroup;
  private dialogConfig;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    let newDt = new Date();
    this.driverForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      personalIdNummber: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      personalIdExpDate: new FormControl(newDt, Validators.required),
      passNumber: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      passExpDate: new FormControl(newDt, Validators.required),
      driversLicenceNumber: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      driversLicenceExpDate: new FormControl(newDt, Validators.required),
      address: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      remark: new FormControl('', Validators.maxLength(100)),
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
    return this.driverForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  public createDriver = (driverFormValue) => {
    if (this.driverForm.valid) {
      this.executeDriverCreation(driverFormValue);
    }
  }

  private executeDriverCreation = (driverFormValue) => {
    const currentdate = new Date().toLocaleString();
    let driver: DriverForCreation = {
      name: driverFormValue.name,
      personalIdNummber: driverFormValue.personalIdNummber,
      personalIdExpDate: driverFormValue.personalIdExpDate,
      passNumber: driverFormValue.passNumber,
      passExpDate: driverFormValue.passExpDate,
      driversLicenceNumber: driverFormValue.driversLicenceNumber,
      driversLicenceExpDate: driverFormValue.driversLicenceExpDate,
      address: driverFormValue.address,
      remark: driverFormValue.remark,
      isInactive: driverFormValue.isInactive,
      lastChangeDateTime: currentdate,
      lastChangeUserId: 0
    }

    let apiUrl = 'api/Drivers';
    this.repository.create(apiUrl, driver)
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
