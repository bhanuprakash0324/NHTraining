using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClasses
{
    internal class Seller
    {
        private string name;
        private string emailid;
        private string service_number;

        public void ReadSeller()
        {
            Console.WriteLine("Enter seller name: ");
            name = (Console.ReadLine());

            Console.WriteLine("Enter seller emailid: ");
            emailid = (Console.ReadLine());

            Console.WriteLine("Enter seller service_number: ");
            service_number = (Console.ReadLine());
        }



        public void PrintSeller()
        {
            Console.WriteLine($"Seller Name={name},Seller EmailId={emailid},Seller Service_Number={service_number}");
        }

    }
}
