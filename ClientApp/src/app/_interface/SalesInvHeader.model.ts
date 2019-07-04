import {SalesInvLine} from './SalesInvLine.model';
import {Customer} from './customer.model';
export class SalesInvHeader {
    id: number;
    invoiceNo: string;
    postingDate: Date;
    externalReferenceNo: string;
    dueDate: Date;
    salesPerson: string;
    orderDate: Date;
    totalAmount: number;
    totalAmountLocal: number;
    paid: boolean;
    invoiced: boolean;
    creditMemo: boolean;
    paymentDate: Date;
    lines?: SalesInvLine[];
    commodityType: string;
    numberOfPallets: number;
    numberofPalletsPlaces: number;
    bruttoWeight: number;
    adrNeeded: boolean;
    remarks: string;
    vechicleRegNumber: string;
    driverName: string;
    routeDistance: number;
    loadRepresentative: string;
    pricePerKm: number;
    crmNumber: string;
    deletedInvoiceLineIds: string;
    currencyId: number;
    currency?: string;
    customerId: number;
    customer?: string;
}
