import { Injectable } from '@angular/core';
import {Router} from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class PrintService {

  isPrinting = false;

  constructor(private router: Router) { }

  printDocument(documentName: string, document: string) {
    this.isPrinting = true;
    let pathurl = `/sales/details/${document}/print`;
    this.router.navigate([pathurl]);
  //   this.router.navigate(['/',
  //   {outlets: {
  //     //'print': ['print', documentName, documentData.join()]
  //     'print': ['print']
  //   }}
  // ]);
  }

  onDataReady() {
    setTimeout(() => {
      window.print();
      this.isPrinting = false;
      this.router.navigate([{outlets: {print: null}}]);
    });
  }

}
