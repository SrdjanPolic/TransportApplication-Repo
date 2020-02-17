export interface CustomerForCreation {
     // id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    email: string;
    paymentCurrency: number;
    vatNumber: string;
    isInactive: boolean;
    personalIdNumber: string;
    note: string;
    lastChangeDateTime: Date;
    lastChangeUserId: number;
}
