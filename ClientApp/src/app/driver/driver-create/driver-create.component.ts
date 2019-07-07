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
      firstName: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      lastName: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      personalId: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      passportNo: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      passportValidUntil: new FormControl(newDt,[Validators.required, Validators.maxLength(50)]),
      driverLicenceNo: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      driverLicenceValidUntil: new FormControl(newDt,[Validators.required, Validators.maxLength(50)]),
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
    let driver: DriverForCreation = {
      firstName: driverFormValue.firstName,
      lastName: driverFormValue.lastName,
      address: driverFormValue.address,
      personalId: driverFormValue.personalId,
      passportNo: driverFormValue.passportNo,
      passportValidUntil: driverFormValue.passportValidUntil,
      driverLicenceNo: driverFormValue.driverLicenceNo,
      driverLincenceValidUntil: driverFormValue.driverLicenceValidUntil
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
