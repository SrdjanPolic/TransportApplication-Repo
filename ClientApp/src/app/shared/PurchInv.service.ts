import { HttpClient } from '@angular/common/http';
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
    return this.http.post(environment.urlAddress + '/PurchInvoice', body);
  }

  getInvoiceList() {
    return this.http.get(environment.urlAddress + '/PurchInvoice').toPromise();
  }

  getInvoiceByID(id:number):any {
    return this.http.get(environment.urlAddress + '/PurchInvoice/' + id).toPromise();
  }

  deleteInvoice(id:number) {
    return this.http.delete(environment.urlAddress + '/PurchInvoice/' + id).toPromise();
  }

}
