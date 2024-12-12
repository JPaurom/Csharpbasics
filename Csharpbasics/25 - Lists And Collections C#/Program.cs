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
