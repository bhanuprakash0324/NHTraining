using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Class_Name_and_brand_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){id=11,name="Beast",price=1500,brand="Kookaburra"},
                new Product(){id=12,name="Kahuna",price=450,brand="kookaburra"},
                new Product(){id=13,name="Nexus",price=1250,brand="SG"},
                new Product(){id =14,name="Super Cover",price=300,brand ="SG"},
                new Product(){id =15,name="Vapor",price=2500,brand ="Grey Nicollas"}
            };

            //For loop
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].price>500)
                     Console.WriteLine($"Product Name: {products[i].name},Product Brand: {products[i].brand}");

            }
            //For Each Loop

            foreach (var p in products)
            {
                if(p.price>500)
                    Console.WriteLine($"Product Name: {p.name},Product Brand: {p.brand}");

            }

            //Lambda Expression
            products.Where(p => p.price > 500).ToList().ForEach(p => Console.WriteLine($"Product Name: {p.name},Product Brand: {p.brand}"));

            //Linq query

            var result = from p in products
                         where p.price > 500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"Product Name: {p.name},Product Brand: {p.brand}"));
             
            Console.ReadLine();

        }
    }
}
