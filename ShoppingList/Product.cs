using System;

namespace ShoppingList
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public int Amount { get; set; }

        public Product(string name, decimal price, string category, string color, int amount)
        {
            Name = name;
            Price = price;
            Category = category;
            Color = color;
            Amount = amount;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Amount: {Amount}");
        }
    }
}
