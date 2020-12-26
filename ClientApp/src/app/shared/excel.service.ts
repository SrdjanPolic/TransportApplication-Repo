// import { Injectable } from '@angular/core';
// import { Workbook} from 'exceljs';
// import * as fs from 'file-saver';

// @Injectable({
//   providedIn: 'root'
// })
// export class ExcelService {

//   constructor() { }

//   generateExcel(data:any) {
//     const title = 'Izveštaj';
//     //const header = ["1","2","3","4","5","6"];
//     let workbook = new Workbook();
//     let worksheet = workbook.addWorksheet('Podaci');
//     worksheet.addRow([title]);
//     //worksheet.addRow([header]);
//     for (let x1 of data) {
//       let x2 = Object.keys(x1);
//       let temp = [];
//       for (let y of x2) {
//         temp.push(x1[y])
//       }
//       worksheet.addRow(temp);
//     }
//     workbook.xlsx.writeBuffer().then ((data) => {
//       let blob = new Blob([data], {type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'});
//       fs.saveAs(blob, 'Izvestaj.xlsx');
//     }
//     )


//   }
// }
