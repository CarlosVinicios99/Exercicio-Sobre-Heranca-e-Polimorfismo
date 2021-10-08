using System;
using System.Collections.Generic;
using Exercicio.Entites;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"\nProduct #{i} data: ");
                Console.Write("Common used or imported (c/u/i): ");
                char typeOfProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(typeOfProduct == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if(typeOfProduct == 'u')
                {
                    Console.Write("ManufactureDate (DD/MM/YYYY): ");
                    string manufactureDate = Console.ReadLine();
                    products.Add(new UsedProduct(name, price, DateTime.Parse(manufactureDate)));
                }
                else
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("Price Tag: ");

            foreach(Product product in products)
            {
                Console.WriteLine("\n" + product.PriceTag());
            }

        }
    }
}
