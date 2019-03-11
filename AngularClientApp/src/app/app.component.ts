import { Component,OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'AngularClientApp';
  apiValues: string[] = [];
  constructor(private _service:HttpClient) {

  }

  ngOnInit() {
   // this._service.get("api/Values").subscribe(result => {
   //   this.apiValues = result.toString();
    }
  
  
}
