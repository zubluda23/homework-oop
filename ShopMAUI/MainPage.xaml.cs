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
                packagingDate: DateTime.Now.AddDays(-2),
                description: "Fresh pasteurized whole milk 3.2%",
                expirationDate: DateTime.Now.AddDays(7),
                quantity: 1.0,
                unit: "L"));

            _products.Add(new FoodProduct(
                name: "Cheddar Cheese",
                price: 135.00m,
                countryOfOrigin: "Poland",
                packagingDate: DateTime.Now.AddDays(-10),
                description: "Aged hard cheese",
                expirationDate: DateTime.Now.AddDays(90),
                quantity: 0.35,
                unit: "kg"));

            _products.Add(new Book(
                name: "Clean Code",
                price: 850.00m,
                countryOfOrigin: "USA",
                packagingDate: DateTime.Now.AddMonths(-6),
                description: "A Handbook of Agile Software Craftsmanship",
                pageCount: 464,
                publisher: "Prentice Hall",
                authors: new List<string> { "Robert C. Martin" }));

            _products.Add(new Book(
                name: "The C# Player's Guide",
                price: 920.00m,
                countryOfOrigin: "USA",
                packagingDate: DateTime.Now.AddMonths(-3),
                description: "Comprehensive guide to C# programming",
                pageCount: 520,
                publisher: "Starbound",
                authors: new List<string> { "RB Whitaker" }));
        }

        private void OnAddFoodClicked(object sender, EventArgs e)
        {
            FoodProduct newFood = new FoodProduct(
                name: $"Product #{_counter}",
                price: 25.00m + (_counter * 5),
                countryOfOrigin: "Ukraine",
                packagingDate: DateTime.Now,
                description: "Standard grocery item",
                expirationDate: DateTime.Now.AddDays(14),
                quantity: 1,
                unit: "pcs");

            _products.Add(newFood);
            _counter++;
        }

        private void OnAddBookClicked(object sender, EventArgs e)
        {
            Book newBook = new Book(
                name: $"New Book #{_counter}",
                price: 300.00m + (_counter * 10),
                countryOfOrigin: "Ukraine",
                packagingDate: DateTime.Now,
                description: "Technical literature",
                pageCount: 200 + (_counter * 20),
                publisher: "Publishing House",
                authors: new List<string> { "Author Name" });

            _products.Add(newBook);
            _counter++;
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