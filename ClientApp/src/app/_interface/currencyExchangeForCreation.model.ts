export interface CurrencyExchangeForCreation {
  currencyId: number;
  startingDate: Date;
  exchangeRateAmount: number;
  lastChangeDateTime: Date;
  lastChangeUserId: number;
}
