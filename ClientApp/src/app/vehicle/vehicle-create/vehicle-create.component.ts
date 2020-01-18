import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { VehicleForCreation } from '../../_interface/vehicleForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';

export interface CarType {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-vehicle-create',
  templateUrl: './vehicle-create.component.html',
  styleUrls: ['./vehicle-create.component.css']
})
export class VehicleCreateComponent implements OnInit {
  public vehicleForm: FormGroup;
  private dialogConfig;

  carTypes: CarType[] = [
    {value: 'Kombi', viewValue: 'Kombi'},
    {value: 'Putničko', viewValue: 'Putničko'},
    {value: 'Lako teretno', viewValue: 'Lako teretno'},
  ];
  constructor(private location: Location, private repository: RepositoryService,
     private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    let newDt = new Date();
    this.vehicleForm = new FormGroup({
      registrationNumber: new FormControl('', [Validators.required, Validators.maxLength(20)]),
      maxWeight: new FormControl(0, [Validators.required]),
      chassisNumber: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      registrationDate: new FormControl(newDt, Validators.required),
      vechicleType: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      isInactive: new FormControl(false),
      remark: new FormControl('', Validators.maxLength(250))
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.vehicleForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  get userId(): string {
    return localStorage.getItem('userId');
  }

  public createVehicle = (vehicleFormValue) => {
    if (this.vehicleForm.valid) {
      this.executeVehicleCreation(vehicleFormValue);
    }
  }

  public setDate(control: string): Date {
    const chosenDate = new Date(this.vehicleForm.get(control).value);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  private executeVehicleCreation = (vehicleFormValue) => {
    const currentdate = new Date().toLocaleString();
    let vehicle: VehicleForCreation = {

      registrationNumber: vehicleFormValue.registrationNumber,
      maxWeight: vehicleFormValue.maxWeight,
      chassisNumber: vehicleFormValue.chassisNumber,
      registrationDate: vehicleFormValue.registrationDate,
      vechicleType: vehicleFormValue.vechicleType,
      isInactive: vehicleFormValue.isInactive,
      remark: vehicleFormValue.remark,
      lastChangeDateTime: currentdate,
      lastChangeUserId: +this.userId
    };
    vehicle.registrationDate = this.setDate('registrationDate');

    let apiUrl = 'api/Vehicles';
    this.repository.create(apiUrl, vehicle)
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
