export interface CurrencyExchangeForCreation {
  currencyId: number;
  startingDate: Date;
  exchangeRateAmount: number;
  lastChangeDateTime: string;
  lastChangeUserId: number;
}
