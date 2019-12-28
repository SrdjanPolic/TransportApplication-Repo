export interface CurrencyExchange {
  id: number;
  currencyId: number;
  startingDate: Date;
  exchangeRateAmount: number;
  lastChangeUserId: number;
}
