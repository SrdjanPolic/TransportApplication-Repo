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
  selector: 'app-vendor-update',
  templateUrl: './vendor-update.component.html',
  styleUrls: ['./vendor-update.component.css']
})
export class VendorUpdateComponent implements OnInit {

  public vendorForm: FormGroup;
  private dialogConfig;
  public vendor: Vendor;

  constructor(private location: Location, private repository: RepositoryService, private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    this.vendorForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)]),
      address: new FormControl('',[Validators.required, Validators.maxLength(50)]),
      city: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      country: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      phoneNo: new FormControl('', [Validators.required, Validators.maxLength(40)]),
      eMail: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      vatGroup: new FormControl(0, [Validators.required, Validators.maxLength(40)]),
      vatNumber: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      isActive: new FormControl(true)
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getVendorById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.vendorForm.controls[controlName].hasError(errorName);
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
        this.vendorForm.patchValue(this.vendor);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateVendor = (vendorFormValue) => {
    if (this.vendorForm.valid) {
      this.executeVendorUpdate(vendorFormValue);
    }
  }

  private executeVendorUpdate = (vendorFormValue) => {
 
    this.vendor.name = vendorFormValue.name;
    this.vendor.address = vendorFormValue.address;
    this.vendor.city = vendorFormValue.city;
    this.vendor.country = vendorFormValue.country;
    this.vendor.phoneNo = vendorFormValue.phoneNo;
    this.vendor.eMail = vendorFormValue.eMail;
    this.vendor.vatGroup = vendorFormValue.vatGroup;
    this.vendor.vatNumber = vendorFormValue.vatNumber;
    this.vendor.isActive = vendorFormValue.isActive;
   
    let apiUrl = `api/Vendors/${this.vendor.id}`;
    this.repository.update(apiUrl, this.vendor)
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
