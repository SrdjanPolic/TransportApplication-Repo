import { Vendor } from './../../../_interface/vendor.model';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-vendor-data',
  templateUrl: './vendor-data.component.html',
  styleUrls: ['./vendor-data.component.css']
})
export class VendorDataComponent implements OnInit {
  @Input() public vendor: Vendor;
  public selectOptions = [{name:'Show', value: 'show'}, {name: `Don't Show`, value: ''}];
  @Output() selectEmitt = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  public onChange = (event) => {
    this.selectEmitt.emit(event.value);
  }

}
