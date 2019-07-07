import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { VehicleForCreation } from '../../_interface/vehicleForCreation.model';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';

@Component({
  selector: 'app-vehicle-create',
  templateUrl: './vendor-create.component.html',
  styleUrls: ['./vendor-create.component.css']
})
export class VehicleCreateComponent implements OnInit {
  public vehicleForm: FormGroup;
  private dialogConfig;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService) { }

  ngOnInit() {
    this.vehicleForm = new FormGroup({
      code: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      name: new FormControl('',[Validators.required, Validators.maxLength(50)]),
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

  public createVehicle = (vehicleFormValue) => {
    if (this.vehicleForm.valid) {
      this.executeVehicleCreation(vehicleFormValue);
    }
  }

  private executeVehicleCreation = (vehicleFormValue) => {
    let vehicle: VehicleForCreation = {
      name: vehicleFormValue.name,
      code: vehicleFormValue.code
    }

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
