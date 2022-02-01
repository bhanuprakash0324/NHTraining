using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Product_classes
{
    internal class Customer
    {
        public int id;
        public string name;
        public string emailid;

        public void ReadCustomer()
        {

            Console.WriteLine("Enter customer id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter customer name: ");
            name = (Console.ReadLine());

            Console.WriteLine("Enter customer emailid: ");
            emailid= (Console.ReadLine());

        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer Id={id},Customer Name={name},Customer EmailId={emailid}");
        }

    }
}
