import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PurchInvHeader } from '../_interface/PurchInvHeader.model';
import { PurchInvLine } from '../_interface/PurchInvLine.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PurchInvService {
  formData: PurchInvHeader;
  PurchInvLines: PurchInvLine[];

  constructor(private http: HttpClient) { }

  saveOrUpdateInvoice() {
    var body = {
      ...this.formData,
      PurchInvLines: this.PurchInvLines
    };
    let options = {headers: new HttpHeaders({'Content-Type': 'application/json'})};
    return this.http.post(environment.urlAddress + '/api/PurchaseInvoiceHeaders', body,options);
  }

  getInvoiceList() {
    return this.http.get(environment.urlAddress + '/api/PurchaseInvoiceHeaders').toPromise();
  }

  getInvoiceByID(id:number):any {
    return this.http.get(environment.urlAddress + '/api/PurchaseInvoiceHeaders/' + id).toPromise();
  }

  deleteInvoice(id:number) {
    return this.http.delete(environment.urlAddress + '/PurchInvoice/' + id).toPromise();
  }

}
