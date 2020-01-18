import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { Vehicle } from '../../_interface/vehicle.model';

export interface CarType {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-vehicle-update',
  templateUrl: './vehicle-update.component.html',
  styleUrls: ['./vehicle-update.component.css']
})
export class VehicleUpdateComponent implements OnInit {

  public vehicleForm: FormGroup;
  private dialogConfig;
  public vehicle: Vehicle;

  carTypes: CarType[] = [
    {value: 'Kombi', viewValue: 'Kombi'},
    {value: 'Putničko', viewValue: 'Putničko'},
    {value: 'Lako teretno', viewValue: 'Lako teretno'},
  ];

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

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

    this.getVehicleById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.vehicleForm.controls[controlName].hasError(errorName);
  }

  get userId(): string {
    return localStorage.getItem('userId');
  }

  public onCancel = () => {
    this.location.back();
  }

  private getVehicleById = () => {
    let vehicleId: string = this.activeRoute.snapshot.params['id'];

    let vehicleByIdUrl: string = `api/Vehicles/${vehicleId}`;

    this.repository.getData(vehicleByIdUrl)
      .subscribe(res => {
        this.vehicle = res as Vehicle;
        this.vehicleForm.patchValue(this.vehicle);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateVehicle = (vehicleFormValue) => {
    if (this.vehicleForm.valid) {
      this.executeVehicleUpdate(vehicleFormValue);
    }
  }

  public setDate(control: string): Date {
    const chosenDate = new Date(this.vehicleForm.get(control).value);
    chosenDate.setMinutes(chosenDate.getMinutes() - chosenDate.getTimezoneOffset());
    return chosenDate;
  }

  private executeVehicleUpdate = (vehicleFormValue) => {

    this.vehicle.registrationNumber = vehicleFormValue.registrationNumber;
    this.vehicle.maxWeight = vehicleFormValue.maxWeight;
    this.vehicle.chassisNumber = vehicleFormValue.chassisNumber;
    this.vehicle.registrationDate = vehicleFormValue.registrationDate;
    this.vehicle.vechicleType = vehicleFormValue.vechicleType;
    this.vehicle.isInactive = vehicleFormValue.isInactive;
    this.vehicle.remark = vehicleFormValue.remark;
    this.vehicle.lastChangeDateTime = new Date().toLocaleString();
    this.vehicle.lastChangeUserId = +this.userId;

    this.vehicle.registrationDate= this.setDate('registrationDate');
    let apiUrl = `api/Vehicles/${this.vehicle.id}`;
    this.repository.update(apiUrl, this.vehicle)
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
