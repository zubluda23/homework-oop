using System;

namespace  ShopMAUI
{
    public class FoodProduct : Product
    {
        public DateTime ExpirationDate { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public FoodProduct(
            string name,
            decimal price,
            string countryOfOrigin,
            DateTime packagingDate,
            string description,
            DateTime expirationDate,
            double quantity,
            string unit)
            : base(name, price, countryOfOrigin, packagingDate, description)
        {
            ExpirationDate = expirationDate;
            Quantity = quantity;
            Unit = unit;
        }

        public override string Details =>
            $"Expires: {ExpirationDate:yyyy-MM-dd} | Qty: {Quantity} {Unit}";
    }
}