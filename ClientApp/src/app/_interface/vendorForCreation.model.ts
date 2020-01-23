export interface VendorForCreation {
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
}
