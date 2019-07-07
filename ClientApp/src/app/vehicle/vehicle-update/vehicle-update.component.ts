import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { Vehicle } from '../../_interface/vehicle.model';

@Component({
  selector: 'app-vehicle-update',
  templateUrl: './vehicle-update.component.html',
  styleUrls: ['./vehicle-update.component.css']
})
export class VehicleUpdateComponent implements OnInit {

  public vehicleForm: FormGroup;
  private dialogConfig;
  public vehicle: Vehicle;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    this.vehicleForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      code: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      
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

  private executeVehicleUpdate = (vehicleFormValue) => {
 
    this.vehicle.name = vehicleFormValue.name;
    this.vehicle.code = vehicleFormValue.code;
   
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
