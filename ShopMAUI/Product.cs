using System;

namespace  ShopMAUI
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal price, string countryOfOrigin, DateTime packagingDate, string description)
        {
            Name = name;
            Price = price;
            CountryOfOrigin = countryOfOrigin;
            PackagingDate = packagingDate;
            Description = description;
        }

   
        public virtual string Details => Description;
    }
}