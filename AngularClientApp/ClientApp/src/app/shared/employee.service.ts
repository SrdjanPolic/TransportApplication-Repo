import { Injectable } from '@angular/core';
import { Employee } from './employee.model';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  formdata : Employee;
  list: Employee[];
  readonly rootURL = "http://localhost:46568/api";

  constructor(private http:HttpClient) { }

  postEmployee(formdata:Employee){
    return this.http.post(this.rootURL + '/Employee',formdata);
  }

  refreshList(){
    this.http.get(this.rootURL + '/Employees')
    .toPromise().then( res => this.list = res as Employee[]);
  }

  PutEmployee(formdata:Employee){
    return this.http.put(this.rootURL + '/Employee/' + formdata.EmployeeID,formdata);
  }
  deleteEmployee(id:number){
    return this.http.delete(this.rootURL + '/Employee/' + id);
  }
}

