import { Account } from './account.model';
export interface Vendor {
    id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    email: string;
    paymentTermsCode: string;
    vatGroup: number;
    vatNumber: string;
    isInactive: boolean;
    lastChangeDateTime: string;
    lastChangeUserId: number;

    accounts?: Account;
}
