import {SalesInvLine} from './SalesInvLine.model';
import {Customer} from './customer.model';
export class SalesInvoicesReport {
    id: number;
    invoiceNo: string;
    travelOrder: string;
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
    partiallyPayed: number;
    commodityType: string;
    numberOfPallets: number;
    numberOfPalletsPlaces: number;
    bruttoWeight: number;
    adrNeeded: boolean;
    remarks: string;
    vechicleRegistration: string;
    driverName: string;
    routeDistance: number;
    loadRepresentative: string;
    pricePerKm: number;
    crmNumber: string;
    checkIssueDate: Date;
    taxLawText: string;
    clienReceiptDocDate: Date;
    ownTransport: boolean;
    deletedInvoiceLineIds: string;
    currencyId: number;
    currency?: string;
    customerId: number;
    customer?: string;
    loadDate: Date;
    unloadDate: Date;
    loadAddress: string;
    unloadAddress: string;
    calculatonExchangeRate: number;
    lastChangeDateTime: Date;
    lastChangeUserId: number;

}
