using System;
using System.Collections.Generic;

namespace  ShopMAUI
{
    public class Book : Product
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }

        public Book(
            string name,
            decimal price,
            string countryOfOrigin,
            DateTime packagingDate,
            string description,
            int pageCount,
            string publisher,
            List<string> authors)
            : base(name, price, countryOfOrigin, packagingDate, description)
        {
            PageCount = pageCount;
            Publisher = publisher;
            Authors = authors ?? new List<string>();
        }

        public override string Details =>
            $"Pages: {PageCount} | Pub: {Publisher} | Authors: {string.Join(", ", Authors)}";
    }
}
