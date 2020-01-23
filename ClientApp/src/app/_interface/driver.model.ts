import {SalesInvHeader} from './SalesInvHeader.model';
export interface Driver {
    id: number;
    name: string;
    personalIdNummber: string;
    personalIdExpDate: Date;
    passNumber: string;
    passExpDate: Date;
    driversLicenceNumber: string;
    driversLicenceExpDate: Date;
    address: string;
    remark: string;
    salesInvoiceHeaders?: SalesInvHeader;
    isInactive: boolean;
    lastChangeDateTime: Date;
    lastChangeUserId: number;
}
