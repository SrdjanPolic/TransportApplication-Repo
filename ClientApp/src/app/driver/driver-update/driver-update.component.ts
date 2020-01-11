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

  constructor(private location: Location, private repository: RepositoryService,
    private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

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

    this.getDriverById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.driverForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  get userId(): string {
    return localStorage.getItem('userId');
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
  public setDate(control: string): Date {
    const chosenDate = new Date(this.driverForm.get(control).value);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  private executeDriverUpdate = (driverFormValue) => {
    this.driver.name = driverFormValue.name,
    this.driver.personalIdNummber = driverFormValue.personalIdNummber,
    this.driver.personalIdExpDate = this.setDate('personalIdExpDate'),
    this.driver.passNumber = driverFormValue.passNumber,
    this.driver.passExpDate = this.setDate('passExpDate');
    this.driver.driversLicenceNumber = driverFormValue.driversLicenceNumber,
    this.driver.driversLicenceExpDate = this.setDate('driversLicenceExpDate'),
    this.driver.address = driverFormValue.address,
    this.driver.remark = driverFormValue.remark,
    this.driver.isInactive = driverFormValue.isInactive;
    this.driver.lastChangeUserId = +this.userId;

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
    );
  }

}
