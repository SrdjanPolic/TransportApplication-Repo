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
  selector: 'app-vehicle-delete',
  templateUrl: './vehicle-delete.component.html',
  styleUrls: ['./vehicle-delete.component.css']
})
export class VehicleDeleteComponent implements OnInit {

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
    private activeRoute: ActivatedRoute) { }

    private dialogConfig;
    public vehicle: Vehicle;

  ngOnInit() {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getVehicleById();
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
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public deleteVehicle = () => {
    let deleteUrl: string = `api/Vehicles/${this.vehicle.id}`;
    this.repository.delete(deleteUrl)
      .subscribe(res => {
        let dialogRef = this.dialog.open(SuccessDialogComponent, this.dialogConfig);
        
        dialogRef.afterClosed()
          .subscribe(result => {
            this.location.back();
          });
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

}
