import { Component, OnInit } from '@angular/core';

import { ToastrService } from 'ngx-toastr';
import { EmployeeService } from '../../shared/employee.service';
import { Employee } from '../../shared/employee.model';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(private service: EmployeeService,
    private toastr:ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(emp:Employee){
    this.service.formdata = Object.assign({},emp);
  }

  onDelete(id:number){
    if(confirm('Želite li da obrišete podatak?')) {
    this.service.deleteEmployee(id).subscribe(res =>{
      this.service.refreshList();
      this.toastr.warning('Podaci su obrisani.','Atomic Sped');
    });
    }
}

}
