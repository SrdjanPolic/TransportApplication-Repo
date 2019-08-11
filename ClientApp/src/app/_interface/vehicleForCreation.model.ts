import {SalesInvHeader} from './SalesInvHeader.model';
export interface VehicleForCreation {
    registrationNumber: string;
    maxWeight: number;
    chassisNumber: string;
    fuelType: string;
    vechicleType: string;
    isInactive: boolean;
    remark: string;
    salesInvoiceHeaders?: SalesInvHeader;
}