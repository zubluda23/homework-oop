using System;

namespace CurrencyConverterApp
{
    public class Converter
    {
        
        private readonly decimal _usdRate;
        private readonly decimal _eurRate;

      
        public Converter(decimal usdRate, decimal eurRate)
        {
            if (usdRate <= 0 || eurRate <= 0)
            {
                throw new ArgumentException("Exchange rates must be strictly positive!");
            }

            _usdRate = usdRate;
            _eurRate = eurRate;
        }

       
        public decimal ConvertUahToUsd(decimal uah) => uah / _usdRate;
        public decimal ConvertUahToEur(decimal uah) => uah / _eurRate;

        public decimal ConvertUsdToUah(decimal usd) => usd * _usdRate;
        public decimal ConvertEurToUah(decimal eur) => eur * _eurRate;
    }
}
