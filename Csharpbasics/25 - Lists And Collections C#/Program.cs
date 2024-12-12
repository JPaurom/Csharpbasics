using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields_exercise_in_C_
{
    class Product
    {
    public class Inventory
    { 
        private List<string> items;
        private Dictionary<string, (double price, int stock)> itemDetails;
        public Inventory() 
        {
                items = new List<string>();
                itemDetails = new Dictionary<string, (double, int)>();
    }

    public void AddItem(string name, double price, int stock)
    {
        items.Add(name);
        itemDetails[name] = (price, stock);
    }

    public void RemoveItem(string name)
    {
        items.Remove(name);
        itemDetails.Remove(name);
        Console.WriteLine($"{name} has been removed from the inventory.");
    }

    public void UpdateStock(string name, int newStock)
    {
        if (itemDetails.ContainsKey(name))
        {
            var item = itemDetails[name];
            itemDetails[name] = (item.price, newStock);
            Console.WriteLine($"Stock of {name} updated to {newStock}.");
        }
    }

    public void PrintInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var item in items)
        {
            var details = itemDetails[item];
            Console.WriteLine($"Product: {item}, Price: {details.price}, Stock: {details.stock}");
        }
    }

    public void PrintMostExpensiveItem()
    {
        var mostExpensiveItem = "";
        double highestPrice = 0;

        foreach (var item in items)
        {
            var details = itemDetails[item];
            if (details.price > highestPrice)
            {
                highestPrice = details.price;
                mostExpensiveItem = item;
            }
        }

        Console.WriteLine($"Most expensive item: {mostExpensiveItem}, Price: {highestPrice}");
    }

    public void CalculateTotalInventoryValue()
    {
        double totalValue = 0;

        foreach (var item in items)
        {
            var details = itemDetails[item];
            totalValue += details.price * details.stock;
        }

        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Phone", 599, 5);
            Console.WriteLine("Initial product details:");
            Console.Write(product.GetProductDetails());

            product.SetName("Laptop");
            product.SetPrice(999.99);
            product.SetQuantity(10);
            Console.WriteLine("\nUpdated product details:");
            Console.WriteLine(product.GetProductDetails());
        }
    }
}
