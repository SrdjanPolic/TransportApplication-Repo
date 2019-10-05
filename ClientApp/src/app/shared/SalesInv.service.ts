import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SalesInvHeader } from '../_interface/SalesInvHeader.model';
import { SalesInvLine } from '../_interface/SalesInvLine.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SalesInvService {
  formData: SalesInvHeader;
  SalesInvLines: SalesInvLine[];

  constructor(private http: HttpClient) { }

  saveOrUpdateInvoice() {
    this.formData.lines = this.SalesInvLines;
    this.formData.paymentDate = this.adjustDateForTimeOffset(this.formData.paymentDate);
    this.formData.dueDate = this.adjustDateForTimeOffset(this.formData.dueDate);
    this.formData.postingDate = this.adjustDateForTimeOffset(this.formData.postingDate);
    this.formData.orderDate = this.adjustDateForTimeOffset(this.formData.orderDate);
    var body = {
      ...this.formData,
      SalesInvLines: this.SalesInvLines
    };
    let options = {headers: new HttpHeaders({'Content-Type': 'application/json'})};
    return this.http.post(environment.urlAddress + '/api/SalesInvoiceHeaders', body, options);
  }

  getInvoiceList() {
    return this.http.get(environment.urlAddress + '/api/SalesInvoiceHeaders').toPromise();
  }

  getInvoiceByID(id:number):any {
    return this.http.get(environment.urlAddress + '/api/SalesInvoiceHeaders/' + id).toPromise();
  }

  deleteInvoice(id:number) {
    return this.http.delete(environment.urlAddress + '/SalesInvoice/' + id).toPromise();
  }

  adjustDateForTimeOffset(dateToAdjust) {
    var offsetMs = dateToAdjust.getTimezoneOffset() * 60000;
    return new Date(dateToAdjust.getTime() - offsetMs);
    }

}
