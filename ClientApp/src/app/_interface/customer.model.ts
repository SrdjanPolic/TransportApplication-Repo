import { Account } from './account.model';
export interface Customer{
    id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    eMail: string;
    vatGroup: number;
    isInactive: boolean;
    lastChangeDate : Date
    accounts?: Account
}
