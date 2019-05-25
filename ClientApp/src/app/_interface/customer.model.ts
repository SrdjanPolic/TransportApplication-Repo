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
    vatNumber: string;
    isInactive: boolean;

    accounts?: Account
}
