using System;

namespace CurrencyConverterApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Currency Converter Setup ===");

            decimal usdRate = ReadPositiveDecimal("Enter USD rate to UAH (e.g., 41.5): ");
            decimal eurRate = ReadPositiveDecimal("Enter EUR rate to UAH (e.g., 45.2): ");

            Converter converter = new Converter(usdRate, eurRate);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n--- Choose conversion option ---");
                Console.WriteLine("1 - Convert UAH to USD");
                Console.WriteLine("2 - Convert UAH to EUR");
                Console.WriteLine("3 - Convert USD to UAH");
                Console.WriteLine("4 - Convert EUR to UAH");
                Console.WriteLine("0 - Exit");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine() ?? string.Empty;

                if (choice == "0")
                {
                    isRunning = false;
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        {
                            decimal uah = ReadPositiveDecimal("Enter amount in UAH: ");
                            decimal usd = converter.ConvertUahToUsd(uah);
                            Console.WriteLine($"Result: {uah:F2} UAH = {usd:F2} USD");
                            break;
                        }
                    case "2":
                        {
                            decimal uah = ReadPositiveDecimal("Enter amount in UAH: ");
                            decimal eur = converter.ConvertUahToEur(uah);
                            Console.WriteLine($"Result: {uah:F2} UAH = {eur:F2} EUR");
                            break;
                        }
                    case "3":
                        {
                            decimal usd = ReadPositiveDecimal("Enter amount in USD: ");
                            decimal uah = converter.ConvertUsdToUah(usd);
                            Console.WriteLine($"Result: {usd:F2} USD = {uah:F2} UAH");
                            break;
                        }
                    case "4":
                        {
                            decimal eur = ReadPositiveDecimal("Enter amount in EUR: ");
                            decimal uah = converter.ConvertEurToUah(eur);
                            Console.WriteLine($"Result: {eur:F2} EUR = {uah:F2} UAH");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                        }
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static decimal ReadPositiveDecimal(string prompt)
        {
            decimal value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

            
                input = input.Replace(',', '.');

                if (decimal.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }
    }
}