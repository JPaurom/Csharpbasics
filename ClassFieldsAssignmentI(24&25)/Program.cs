using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldsAssignmentI_24_25_
{
    class Product
    {
        //Private fields to store product with name, price and quantity
        private string name;
        private double price;
        private int stock;

        //Constructor 
        public Product(string name, double price, int stock)
        {
            this.name = name; // Assign the product name
            SetPrice(price); // Validate and set the product price
            SetStock(stock);  //Validate and set the stock quantity

        }
        public void SetName(string name)
        {
            //Assign a valid name or default to "Invalid name" if input is null or empty
            this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
        }

        //Method to get the name of the product
        public string GetName()
        {
            //Return the name of the product
            return name;
        }
        //Method to set the price of the product
        public void SetPrice(double price)
        { 
            //Assign a positive price or default to 0 if input is invalid
            this.price = price > 0 ? price : 0; 
        }
        //Method to get the price of the product
        public double GetPrice()
        {
            //Return the price of the product
            return price;
        }
        //Method to set the quantity of the product in stock
        public void SetStock(int stock)
        { 
            //Assign a non negative value or default to 0 if input is invalid
            this.stock = stock >= 0 ? stock : 0;
        }
        //Method to get the quantity of the product in stock
        public int GetStock()
        {
            // return the stock quantity
            return stock;
        }

        //Method to return the details of the product
        public string ReturnDetails()
        {
            //return the details about the product "Name, price, stock"
            return $"Name: {name}\nPrice: {price}$\nStock: {stock}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the product class
            Product product = new Product("Laptop", 999.99, 20);
            Console.WriteLine(product.ReturnDetails());
            //Update product details
            product.SetName("Smartphone");
            product.SetPrice(599.99);
            product.SetStock(20);

            //Display product details
            Console.WriteLine(product.ReturnDetails());
            Console.ReadLine();
              
        }
    }
}
