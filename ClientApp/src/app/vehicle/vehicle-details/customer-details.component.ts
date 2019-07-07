import { Component, OnInit } from '@angular/core';
import { Customer } from './../../_interface/customer.model';
import { Router, ActivatedRoute } from '@angular/router';
import { RepositoryService } from './../../shared/repository.service';
import { ErrorHandlerService } from './../../shared/error-handler.service';

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.css']
})
export class CustomerDetailsComponent implements OnInit {
  public customer: Customer;
  public showAccounts;

  constructor(private repository: RepositoryService, private router: Router, 
    private activeRoute: ActivatedRoute, private errorHandler: ErrorHandlerService) { }

  ngOnInit() {
    this.getCustomerDetails();
  }

  private getCustomerDetails = () =>{
    let id: string = this.activeRoute.snapshot.params['id'];
    let apiUrl: string = `api/customer/${id}/account`;
 
    this.repository.getData(apiUrl)
    .subscribe(res => {
      this.customer = res as Customer;
    },
    (error) =>{
      this.errorHandler.handleError(error);
    })
  }
}
