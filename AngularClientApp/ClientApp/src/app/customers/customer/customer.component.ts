import { Component, OnInit } from '@angular/core';
import {CustomerService} from '../../shared/customer.service';
import {NotificationService} from '../../shared/notification.service';
import {MatDialogRef} from '@angular/material';
@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  constructor(private service: CustomerService,
              private Notification: NotificationService,
              public dialogRef: MatDialogRef<CustomerComponent>) { }

  VATGroups = [
    { id: 1, value: '0%'},
    {id: 2, value: '20%'}
  ];

  ngOnInit() {
    this.service.getCustomers();
  }
  onClear() {
    this.service.form.reset();
    this.service.initializeFormGroup();
  }
  onSubmit(){
    if (this.service.form.valid) {
      if (!this.service.form.get('$key').value) 
        this.service.insertCustomer(this.service.form.value);
      else 
        this.service.updateCustomer(this.service.form.value);
      this.service.form.reset();
      this.service.initializeFormGroup();
      this.Notification.success(':: Uspešno snimljeno.');
      this.onClose();
    }
  }

  onClose(){
    this.service.form.reset();
    this.service.initializeFormGroup();
    this.dialogRef.close();
  }
}
