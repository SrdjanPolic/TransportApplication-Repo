export class SalesInvHeader {
    id: number;
    InvoiceNo: string;
    PostingDate: Date;
    ExternalReferenceNo: string;
    DueDate: Date;
    TotalAmount: number;
    Paid: boolean;
    Invoiced: boolean;
    CreditMemo: boolean;
    PaymentDate: Date;
    CurrencyId: number;
    CustomerId: number;
    DeletedSalesInvLineIDs: string;
}
