export interface CurrencyExchange {
  id: number;
  currencyId: number;
  startingDate: Date;
  exchangeRateAmount: number;
  lastChangeDateTime: string;
  lastChangeUserId: number;
}
