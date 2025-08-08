namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            // Create sample products list
            var products = new List<Product>
            {
                new Product(1, "Laptop", 10, 999.99),
                new Product(2, "Mouse", 3, 25.50),
                new Product(3, "Keyboard", 15, 45.00),
                new Product(4, "Monitor", 2, 150.00)
            };

            // Display total inventory value
            Console.WriteLine($"Total Inventory Value: R{products.TotalValue():F2}");

            // Display products that are low in stock
            Console.WriteLine("Products low in stock:");
            foreach (var p in products.LowStock())
            {
                Console.WriteLine($"- {p.Name} (Quantity: {p.Quantity})");
            }

            // Using LINQ anonymous types to display product names and prices
            Console.WriteLine("Product Names and Prices:");
            var productInfo = from p in products
                              select new { p.Name, p.Price };

            foreach (var item in productInfo)
            {
                Console.WriteLine($"Name: {item.Name}, Price: R{item.Price:F2}");
            }
        }
    }
}