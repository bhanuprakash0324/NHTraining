using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClasses
{
    internal class Product
    {
        private int id;
        private string name;
        private int price;

        public void ReadProducts()
        {
            Console.WriteLine("Enter product id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name: ");
            name = (Console.ReadLine());

            Console.WriteLine("Enter product price: ");
           price = Convert.ToInt32(Console.ReadLine());
        }



        public void PrintProducts()
        {
            Console.WriteLine($"Product Id={id},Product Name={name},Product Price={price}");
        }

    }
}
