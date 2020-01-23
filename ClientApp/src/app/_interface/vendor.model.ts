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
    paymentCurrency: number;
    vatNumber: string;
    isInactive: boolean;
    lastChangeDateTime: Date;
    lastChangeUserId: number;

    accounts?: Account;
}
