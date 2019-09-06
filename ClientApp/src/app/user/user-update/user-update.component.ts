import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { SuccessDialogComponent } from '../../shared/dialogs/success-dialog/success-dialog.component';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { ActivatedRoute } from '@angular/router';
import { User } from '../../auth/user.model';

@Component({
  selector: 'app-user-update',
  templateUrl: './user-update.component.html',
  styleUrls: ['./user-update.component.css']
})
export class UserUpdateComponent implements OnInit {

  public userForm: FormGroup;
  private dialogConfig;
  public user: User;

  constructor(private location: Location, private repository: RepositoryService,
    private dialog: MatDialog, private errorService: ErrorHandlerService,
              private activeRoute: ActivatedRoute) { }

  ngOnInit() {
    this.userForm = new FormGroup({
      userName: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      password: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      isAdmin: new FormControl(false),
      isInactive: new FormControl(false)
    });

    this.dialogConfig = {
      height: '200px',
      width: '400px',
      disableClose: true,
      data: {}
    }

    this.getUserById();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.userForm.controls[controlName].hasError(errorName);
  }

  public onCancel = () => {
    this.location.back();
  }

  private getUserById = () => {
    let userId: string = this.activeRoute.snapshot.params['id'];

    let userByIdUrl: string = `api/Users/${userId}`;

    this.repository.getData(userByIdUrl)
      .subscribe(res => {
        this.user = res as User;
        this.userForm.patchValue(this.user);
      },
      (error) => {
        this.errorService.dialogConfig = this.dialogConfig;
        this.errorService.handleError(error);
      })
  }

  public updateUser = (userFormValue) => {
    if (this.userForm.valid) {
      this.executeUserUpdate(userFormValue);
    }
  }

  private executeUserUpdate = (userFormValue) => {
    this.user.username =  userFormValue.userName,
    this.user.password = userFormValue.password,
    this.user.isAdmin = userFormValue.isAdmin,
    this.user.isInactive = userFormValue.isInactive;

    let apiUrl = `api/Users/${this.user.id}`;
    this.repository.update(apiUrl, this.user)
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
