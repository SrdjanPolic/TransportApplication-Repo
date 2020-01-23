import { Account } from './account.model';
export interface Customer {
    id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    email: string;
    paymentCurrency: number;
    vatNumber: string;
    isInactive: boolean;
    accounts?: Account;
    personalIdNumber: string;
    lastChangeDateTime: Date;
    lastChangeUserId: number;
}
