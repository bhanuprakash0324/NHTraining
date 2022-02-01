using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClasses
{
    internal class Customer
    {
        private int id;
        private string name;
        private string mobile_number;

        public void ReadCustomer()
        {

            Console.WriteLine("Enter customer id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter customer name: ");
            name = (Console.ReadLine());

            Console.WriteLine("Enter customer mobile number: ");
            mobile_number = (Console.ReadLine());

        }



        public void PrintCustomer()
        {
            Console.WriteLine($"Customer Id={id},Customer Name={name}, Customer Mobile Number={mobile_number}");
        }

    }
}
