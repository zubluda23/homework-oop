using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ShopMAUI
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Product> _products;
        private int _counter = 1;
        private bool _toggleProductType = false;

        public MainPage()
        {
            InitializeComponent();

            _products = new ObservableCollection<Product>();
            SeedInitialProducts();

            ProductsCollectionView.ItemsSource = _products;
        }

        private void SeedInitialProducts()
        {
            _products.Add(new FoodProduct(
                name: "Organic Milk",
                price: 42.50m,
                countryOfOrigin: "Ukraine",
                packagingDate: new DateTime(2026, 10, 4),
                description: "Fresh pasteurized milk",
                expirationDate: new DateTime(2026, 10, 18),
                quantity: 1,
                unit: "L"
            ));

            _products.Add(new FoodProduct(
                name: "Cheddar Cheese",
                price: 135.00m,
                countryOfOrigin: "Poland",
                packagingDate: new DateTime(2026, 9, 26),
                description: "Aged hard cheese",
                expirationDate: new DateTime(2027, 1, 4),
                quantity: 0.35,
                unit: "kg"
            ));

            _products.Add(new Book(
                name: "Clean Code",
                price: 850.00m,
                countryOfOrigin: "USA",
                packagingDate: new DateTime(2026, 4, 6),
                description: "A handbook of agile software craftsmanship",
                pageCount: 464,
                publisher: "Prentice Hall",
                authors: new List<string> { "Robert C. Martin" }
            ));

            _products.Add(new Book(
                name: "The C# Player's Guide",
                price: 920.00m,
                countryOfOrigin: "USA",
                packagingDate: new DateTime(2026, 7, 6),
                description: "Comprehensive tutorial for C# language",
                pageCount: 520,
                publisher: "Starbound",
                authors: new List<string> { "RB Whitaker" }
            ));
        }

        private void OnAddProductClicked(object sender, EventArgs e)
        {
            _counter++;

            if (_toggleProductType)
            {
                _products.Add(new FoodProduct(
                    name: $"Food Item #{_counter}",
                    price: 45.00m + _counter * 5,
                    countryOfOrigin: "Ukraine",
                    packagingDate: DateTime.Now,
                    description: "Fresh delivery batch",
                    expirationDate: DateTime.Now.AddDays(14),
                    quantity: 1,
                    unit: "pcs"
                ));
            }
            else
            {
                _products.Add(new Book(
                    name: $"Book Title #{_counter}",
                    price: 250.00m + _counter * 15,
                    countryOfOrigin: "USA",
                    packagingDate: DateTime.Now,
                    description: "Technical textbook edition",
                    pageCount: 200 + _counter * 25,
                    publisher: "TechPress",
                    authors: new List<string> { $"Author {_counter}" }
                ));
            }

            _toggleProductType = !_toggleProductType;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            if (ProductsCollectionView.SelectedItem is Product selectedProduct)
            {
                _products.Remove(selectedProduct);
                ProductsCollectionView.SelectedItem = null;
            }
            else if (_products.Count > 0)
            {
                _products.RemoveAt(_products.Count - 1);
            }
        }
    }
}