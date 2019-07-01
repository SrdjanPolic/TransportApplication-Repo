export class SalesInvLine {
    id: number;
    loadDate: Date;
    unloadDate: Date;
    loadAddress: string;
    unloadAddress: string;
    exportCustoms: string;
    importCustoms: string;
    quantity: number;
    unitPrice: number;
    discountPercent: number;
    lineAmount: number;
    remark: string;
    description: string;
    vatPercent: number;
    salesHeaderId: number;

}
