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
        private string name;
        private double price;
        private int stock;

        public Product(string name, double price, int stock)        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
         public string GetName()
        {
            return this.name;
        }
        public void SetPrice(double price)
        {
            this.price = price; 
        }
        public double GetPrice()
        { 
            return this.price; 
        }
        public void SetQuantity(int stock)
        { 
            this.stock = stock; 
        }
        public int GetQuantity()
        {
            return this.stock;
        }
        public string GetProductDetails()
        {
            return $"Name: {this.name}, Price: {this.price}, Stock: {this.stock}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Phone", 599, 5 );
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
