import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router';
import { TravelOrderProfit} from './../../_interface/travelOrderProfit.model';
import { RepositoryService } from 'src/app/shared/repository.service';

@Component({
  selector: 'app-travel-order',
  templateUrl: './travel-order.component.html',
  styleUrls: ['./travel-order.component.css']
})
export class TravelOrderComponent implements OnInit {
travelOrderProfit: TravelOrderProfit;
  constructor(
    private router: Router,
    private repoService: RepositoryService,
    private currentRoute: ActivatedRoute) { }

  ngOnInit() {
    const travelOrderId = '3-1/2020';
    const getTravelOrdersUrl = `api/Reports/GetTravelOrderProfitReport/${travelOrderId}`;
    this.repoService.getData(getTravelOrdersUrl).subscribe(res => this.travelOrderProfit = res as TravelOrderProfit);
  }

}
