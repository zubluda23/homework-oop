using System;

namespace CurrencyConverterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            decimal usd = 41.50m;
            decimal eur = 45.20m;
            Converter converter = new Converter(usd, eur);

            Console.WriteLine("Currency Converter Program ");
            Console.WriteLine($"Current exchange rates: 1 USD = {usd} UAH, 1 EUR = {eur} UAH\n");

            decimal uahAmount = 2000m;
            Console.WriteLine($" Conversion from UAH to Currencies ({uahAmount:F2} UAH) ");
            Console.WriteLine($"{uahAmount:F2} UAH = {converter.ConvertUahToUsd(uahAmount):F2} USD");
            Console.WriteLine($"{uahAmount:F2} UAH = {converter.ConvertUahToEur(uahAmount):F2} EUR\n");

  
            decimal usdAmount = 100m;
            decimal eurAmount = 100m;
            Console.WriteLine("Conversion from Currencies to UAH ");
            Console.WriteLine($"{usdAmount:F2} USD = {converter.ConvertUsdToUah(usdAmount):F2} UAH");
            Console.WriteLine($"{eurAmount:F2} EUR = {converter.ConvertEurToUah(eurAmount):F2} UAH");

            
        }
    }
}