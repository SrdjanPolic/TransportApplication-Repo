import { Component, OnInit } from '@angular/core';
import { Vendor } from './../../_interface/vendor.model';
import { Router, ActivatedRoute } from '@angular/router';
import { RepositoryService } from './../../shared/repository.service';
import { ErrorHandlerService } from './../../shared/error-handler.service';

@Component({
  selector: 'app-vendor-details',
  templateUrl: './vendor-details.component.html',
  styleUrls: ['./vendor-details.component.css']
})
export class VendorDetailsComponent implements OnInit {
  public vendor: Vendor;
  public showAccounts;

  constructor(private repository: RepositoryService, private router: Router, 
    private activeRoute: ActivatedRoute, private errorHandler: ErrorHandlerService) { }

  ngOnInit() {
    this.getVendorDetails();
  }

  private getVendorDetails = () =>{
    let id: string = this.activeRoute.snapshot.params['id'];
    let apiUrl: string = `api/vendor/${id}/account`;
 
    this.repository.getData(apiUrl)
    .subscribe(res => {
      this.vendor = res as Vendor;
    },
    (error) =>{
      this.errorHandler.handleError(error);
    })
  }
}
