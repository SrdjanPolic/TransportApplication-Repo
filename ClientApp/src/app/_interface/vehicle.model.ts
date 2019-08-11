import {SalesInvHeader} from './SalesInvHeader.model';
export interface Vehicle {
    id: number;
    registrationNumber: string;
    maxWeight: number;
    chassisNumber: string;
    fuelType: string;
    vechicleType: string;
    isInactive: boolean;
    remark: string;
    salesInvoiceHeaders?: SalesInvHeader;
}
