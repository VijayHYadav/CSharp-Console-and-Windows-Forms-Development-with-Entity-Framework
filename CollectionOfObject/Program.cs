using System;
using System.Collections.Generic;
using ECommerce;

namespace CollectionOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an empyt collection
            List<Product> products = new List<Product>();

            // loop to read data from user
            string choice;
            do
            {
                Console.Write("Enter product Id:");
                int pid = int.Parse(Console.ReadLine());
                
                Console.Write("Enter product Name:");
                string pName = Console.ReadLine();

                Console.Write("Enter product Price:");
                double pPrice = double.Parse(Console.ReadLine());

                Console.Write("Enter product DateOfManufacture(yyyy-MM-dd):");
                DateTime pDOM = DateTime.Parse(Console.ReadLine());

                Product product = new Product() { Id = pid, Name= pName, price=pPrice, DateOfManufacture=pDOM};

                products.Add(product);

                // Ask the user to continue
                Console.WriteLine("Product Added.\n");
                Console.WriteLine("Do you want to continue to next product?(Yes/No)");
                choice = Console.ReadLine();

            } while (choice != "No" && choice != "no" && choice != "n" && choice != "N");


            foreach (Product item in products)
            {
                Console.WriteLine(item.Id + " : " + item.Name + " : " + item.price + " : " + item.DateOfManufacture.ToShortDateString());
            }

            Console.ReadKey();
        }
    }
}
