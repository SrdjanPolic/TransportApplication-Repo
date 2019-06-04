import { HttpClient } from '@angular/common/http';
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
    var body = {
      ...this.formData,
      SalesInvLines: this.SalesInvLines
    };
    return this.http.post(environment.urlAddress + '/SalesInvoice', body);
  }

  getInvoiceList() {
    return this.http.get(environment.urlAddress + '/SalesInvoice').toPromise();
  }

  getInvoiceByID(id:number):any {
    return this.http.get(environment.urlAddress + '/SalesInvoice/' + id).toPromise();
  }

  deleteInvoice(id:number) {
    return this.http.delete(environment.urlAddress + '/SalesInvoice/' + id).toPromise();
  }

}
