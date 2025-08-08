using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    // Represents a product in inventory
    public class Product
    {
        public int ID { get; set; }           
        public string Name { get; set; }     
        public int Quantity { get; set; }    
        public double Price { get; set; }    

        // Constructor to initialize product properties
        public Product(int id, string name, int quantity, double price)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

    // Extension methods for List<Product>
    public static class ProductExtensions
    {
        // Calculate total inventory value (Price * Quantity)
        //(StackOverFlow, 2018)
        public static double TotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Price * p.Quantity);
        }

        // Filter products low in stock 
        //(Microsoft Corporation, 2025)
        public static List<Product> LowStock(this List<Product> products, int threshold = 5)
        {
            return products.Where(p => p.Quantity <= threshold).ToList();
        }
    }
}
//Microsoft Corporation. (n.d.) LINQ (Language-Integrated Query) - Filtering with Where. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/filtering-data [Accessed: 8 August 2025].
//Stack Overflow community. (2018) Summing numbers using pointer arithmetic. Available at: https://stackoverflow.com/questions/50155739/summing-numbers-using-pointer-arithmetic [Accessed: 8 August 2025].