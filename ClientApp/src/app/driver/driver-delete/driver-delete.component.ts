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
  selector: 'app-driver-delete',
  templateUrl: './driver-delete.component.html',
  styleUrls: ['./driver-delete.component.css']
})
export class DriverDeleteComponent implements OnInit {

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
    private activeRoute: ActivatedRoute) { }

    private dialogConfig;
    public driver: Driver;

  ngOnInit() {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getDriverById();
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
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public deleteDriver = () => {
    let deleteUrl: string = `api/Drivers/${this.driver.id}`;
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
