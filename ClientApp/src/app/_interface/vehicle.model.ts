import {SalesInvHeader} from './SalesInvHeader.model';
export interface Vehicle {
    id: number;
    registrationNumber: string;
    maxWeight: number;
    chassisNumber: string;
    registrationDate: Date;
    vechicleType: string;
    isInactive: boolean;
    remark: string;
    salesInvoiceHeaders?: SalesInvHeader;
    lastChangeDateTime: string;
    lastChangeUserId: number;
}
