import { Injectable } from '@angular/core';
import {Router} from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(private router: Router) { }

  convertCountryCodeToName(countryCode: string)
  {
    let countryName = '';
    switch (countryCode) {

      case 'BE':
        countryName = 'Belgien';
        break;
      case 'BG':
        countryName = 'Bulgarien';
        break;
      case 'CZ':
        countryName = 'Tschechien';
        break;
      case 'DK':
        countryName = 'Dänemark';
        break;
      case 'DE':
        countryName = 'Deutschland';
        break;
      case 'EE':
        countryName = 'Estland';
        break;
      case 'IE':
        countryName = 'Irland';
        break;
      case 'EL':
        countryName = 'Griechenland';
        break;
      case 'ES':
        countryName = 'Spanien';
        break;
      case 'FR':
        countryName = 'Frankreich';
        break;
      case 'HR':
        countryName = 'Kroatien';
        break;
      case 'IT':
        countryName = 'Italien';
        break;
      case 'CY':
        countryName = 'Zypern';
        break;
      case 'LV':
        countryName = 'Lettland';
        break;
      case 'LT':
        countryName = 'Litauen';
        break;
      case 'LU':
        countryName = 'Luxemburg';
        break;
      case 'HU':
        countryName = 'Ungarn';
        break;
      case 'MT':
        countryName = 'Malta';
        break;
      case 'NL':
        countryName = 'Niederlande';
        break;
      case 'AT':
        countryName = 'Österreich';
        break;
      case 'PL':
        countryName = 'Polen';
        break;
      case 'PT':
        countryName = 'Portugal';
        break;
      case 'RO':
        countryName = 'Rumänien';
        break;
      case 'SI':
        countryName = 'Slowenien';
        break;
      case 'SK':
        countryName = 'Slowakei';
        break;
      case 'FI':
        countryName = 'Finnland';
        break;
      case 'SE':
        countryName = 'Schweden';
        break;
      case 'IS':
        countryName = 'Island';
        break;
      case 'LI':
        countryName = 'Liechtenstein';
        break;
      case 'NO':
        countryName = 'Norwegen';
        break;
      case 'CH':
        countryName = 'Schweiz';
        break;
      case 'UK':
        countryName = 'Vereinigtes Königreich';
        break;
      case 'ME':
        countryName = 'Montenegro';
        break;
      case 'MK':
        countryName = 'Nordmazedonien';
        break;
      case 'AL':
        countryName = 'Albanien';
        break;
      case 'RS':
        countryName = 'Serbien';
        break;
      case 'TR':
        countryName = 'Turkei';
        break;
      case 'BA':
        countryName = 'Bosnien und Herzegowina';
        break;
      case 'XK':
        countryName = 'Kosovo';
        break;

      default:
        break;
    }
    return countryName;
  }

}
