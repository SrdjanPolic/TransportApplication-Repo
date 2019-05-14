import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { Vendor } from '../../_interface/vendor.model';

@Component({
  selector: 'app-vendor-delete',
  templateUrl: './vendor-delete.component.html',
  styleUrls: ['./vendor-delete.component.css']
})
export class VendorDeleteComponent implements OnInit {

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
    private activeRoute: ActivatedRoute) { }

    private dialogConfig;
    public vendor: Vendor;

  ngOnInit() {
    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getVendorById();
  }

  public onCancel = () => {
    this.location.back();
  }

  private getVendorById = () => {
    let vendorId: string = this.activeRoute.snapshot.params['id'];
      
    let vendorByIdUrl: string = `api/Vendors/${vendorId}`;
   
    this.repository.getData(vendorByIdUrl)
      .subscribe(res => {
        this.vendor = res as Vendor;
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public deleteVendor = () => {
    let deleteUrl: string = `api/Vendors/${this.vendor.id}`;
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
