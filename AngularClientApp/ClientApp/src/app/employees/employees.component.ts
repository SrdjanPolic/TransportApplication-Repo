import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../shared/employee.service';
import { NgForm } from '@angular/forms';
import { Toast, ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  constructor(private service:EmployeeService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm){
    if (form != null)
      form.resetForm();
    this.service.formdata = {
      EmployeeID : null,
      FullName : '',
      Position: '',
      EMPCode: '',
      Mobile: ''
    }
  }
   onSubmit(form: NgForm){
     if (form.value.EmployeeID == null)
     this.insertRecord(form);
     else
     this.updateRecord(form);
   } 
   insertRecord(form: NgForm){
     this.service.postEmployee(form.value).subscribe( res =>{
       this.toastr.success('Podaci su uneti.','Atomic Sped');
       this.resetForm(form);
       this.service.refreshList();
     });
   }
   updateRecord(form:NgForm){
     this.service.PutEmployee(form.value).subscribe( res =>{
      this.toastr.info('Podaci su izmenjeni.','Atomic Sped');
      this.resetForm(form);
      this.service.refreshList();
    });
   }
     
   
}
