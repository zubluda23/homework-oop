using System;

namespace CurrencyConverterApp
{
    public class Converter
    {
        public decimal UsdRate { get; private set; }
        public decimal EurRate { get; private set; }

        public Converter(decimal usdRate, decimal eurRate)
        {
            if (usdRate <= 0 || eurRate <= 0)
            {
                throw new ArgumentException("Exchange rates must be greater than zero.");
            }

            UsdRate = usdRate;
            EurRate = eurRate;
        }

        public decimal ConvertUahToUsd(decimal amountInUah)
        {
            return amountInUah / UsdRate;
        }

        public decimal ConvertUahToEur(decimal amountInUah)
        {
            return amountInUah / EurRate;
        }

     
        public decimal ConvertUsdToUah(decimal amountInUsd)
        {
            return amountInUsd * UsdRate;
        }

        public decimal ConvertEurToUah(decimal amountInEur)
        {
            return amountInEur * EurRate;
        }
    }
}
