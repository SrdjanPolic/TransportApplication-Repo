import {PurchInvLine} from './PurchInvLine.model';
import {Vendor} from './vendor.model';
export class PurchInvHeader {
    id: number;
    invoiceNo: string;
    travelOrder: string;
    supplierInvoiceNo: string;
    postingDate: Date;
    externalReferenceNo: string;
    dueDate: Date;
    totalAmount: number;
    totalAmountLocal: number;
    paid: boolean;
    invoiced: boolean;
    creditMemo: boolean;
    paymentDate: Date;
    currency?: string;
    currencyId: number;
    vendorId: number;
    vendor?: Vendor;
    deletedInvoiceLineIds: string;
    lines?: PurchInvLine[];
    lastChangeDateTime: string;
    lastChangeUserId: number;

}
