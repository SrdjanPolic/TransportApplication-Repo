import { Injectable } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms';
import {AngularFireDatabase, AngularFireList} from '@angular/fire/database';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private firebase: AngularFireDatabase) { }

  customerList: AngularFireList<any>;

  form: FormGroup = new FormGroup({
    $key: new FormControl(null),
    Name: new FormControl('', Validators.required),
    Address: new FormControl(''),
    City: new FormControl(''),
    Country: new FormControl(''),
    PhoneNo: new FormControl('', Validators.minLength(6)),
    EMail: new FormControl('', Validators.email),
    VATGroup: new FormControl(0, Validators.required),
    VATNumber: new FormControl('', Validators.required),
    Disabled: new FormControl(false)
  });

  initializeFormGroup() {
    this.form.setValue({
      $key: null,
      Name: '',
      Address: '',
      City: '',
      Country: '',
      PhoneNo: '',
      EMail: '',
      VATGroup: 0,
      VATNumber: '',
      Disabled: false
    });
  }

  getCustomers() {
    this.customerList = this.firebase.list('customers');
    return this.customerList.snapshotChanges();
  }
  insertCustomer(customer) {
    this.customerList.push({
      Name: customer.Name,
      Address: customer.Address,
      City: customer.City,
      Country: customer.Country,
      PhoneNo: customer.PhoneNo,
      EMail: customer.EMail,
      VATGroup: customer.VATGroup,
      VATNumber: customer.VATNumber,
      Disabled: customer.Disabled

    });

  }
  updateCustomer(customer) {
    this.customerList.update(customer.$key,
      {
      Name: customer.Name,
      Address: customer.Address,
      City: customer.city,
      Country: customer.Country,
      PhoneNo: customer.PhoneNo,
      EMail: customer.EMail,
      VATGroup: customer.VATGroup,
      VATNumber: customer.VATNumber,
      Disabled: customer.Disabled

      });
  }

  deleteCustomer($key: string) {
    this.customerList.remove($key);
  }

  populateForm(customer) {
    this.form.setValue(customer);
  }
}
