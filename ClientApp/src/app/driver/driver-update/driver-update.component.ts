import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { Driver } from '../../_interface/driver.model';

@Component({
  selector: 'app-driver-update',
  templateUrl: './driver-update.component.html',
  styleUrls: ['./driver-update.component.css']
})
export class DriverUpdateComponent implements OnInit {

  public driverForm: FormGroup;
  private dialogConfig;
  public driver: Driver;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    let newDt = new Date();
    this.driverForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      lastName: new FormControl('',[Validators.required, Validators.maxLength(30)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(80)]),
      personalId: new FormControl('',[Validators.required, Validators.maxLength(20)]),
      passportNo: new FormControl('',[Validators.required, Validators.maxLength(20)]),
      passportValidUntil: new FormControl(newDt,[Validators.required]),
      driverLicenceNo: new FormControl('',[Validators.required, Validators.maxLength(20)]),
      driverLicenceValidUntil: new FormControl(newDt,[Validators.required])
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getDriverById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.driverForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  private getDriverById = () => {
    let driverId: string = this.activeRoute.snapshot.params['id'];
      
    let driverByIdUrl: string = `api/Drivers/${driverId}`;
   
    this.repository.getData(driverByIdUrl)
      .subscribe(res => {
        this.driver = res as Driver;
        this.driverForm.patchValue(this.driver);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateDriver = (driverFormValue) => {
    if (this.driverForm.valid) {
      this.executeDriverUpdate(driverFormValue);
    }
  }

  private executeDriverUpdate = (driverFormValue) => {
 
    this.driver.firstName = driverFormValue.firstName;
    this.driver.lastName = driverFormValue.lastName;
    this.driver.address = driverFormValue.address;
    this.driver.personalID = driverFormValue.personalID;
    this.driver.passportNo = driverFormValue.passportNo;
    this.driver.passportValidUntil = driverFormValue.passportValidUntil;
    this.driver.driverLicenceNo = driverFormValue.driverLicenceNo;
    this.driver.driverLincenceValidUntil = driverFormValue.driverLicenceValidUntil;
   
    let apiUrl = `api/Drivers/${this.driver.id}`;
    this.repository.update(apiUrl, this.driver)
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
