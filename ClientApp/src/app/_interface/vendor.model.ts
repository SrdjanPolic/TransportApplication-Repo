import { Account } from './account.model';
export interface Vendor{
    id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    eMail: string;
    vatGroup: number;
    vatNumber: string;
    isActive: boolean;

    accounts?: Account
}
