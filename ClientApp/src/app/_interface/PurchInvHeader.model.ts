import {PurchInvLine} from './PurchInvLine.model';
import {Vendor} from './vendor.model';
export class PurchInvHeader {
    id: number;
    invoiceNo: string;
    postingDate: Date;
    externalReferenceNo: string;
    dueDate: Date;
    totalAmount: number;
    paid: boolean;
    invoiced: boolean;
    creditMemo: boolean;
    paymentDate: Date;
    currency?: string;
    currencyId: number;
    vendorId: number;
    vendor?: Vendor;
    deletedPurchInvLineIDs: string;
    lines?: PurchInvLine;



}
