import {PurchInvLine} from './PurchInvLine.model';
import {Vendor} from './vendor.model';
export class PurchInvHeader {
    id: number;
    invoiceNo: string;
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
    lastChangeDateTime: Date;
    lastChangeUserId: number;

}
