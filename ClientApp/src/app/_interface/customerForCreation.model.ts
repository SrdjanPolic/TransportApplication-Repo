export interface CustomerForCreation {
     // id: string;
    name: string;
    address: string;
    city: string;
    country: string;
    phoneNo: string;
    email: string;
    vatGroup: number;
    vatNumber: string;
    isInactive: boolean;
    lastChangeDateTime: string;
    lastChangeUserId: number;
}
