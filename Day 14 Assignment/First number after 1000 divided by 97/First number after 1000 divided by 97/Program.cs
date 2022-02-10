using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_number_after_1000_divided_by_97
{
    //Author: Bhanu Prakash Reddy
    //WACP for print first number after 1000 divided by 97
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            for (i = 1000; i<=1097; i++)
            {
                if (i % 97 == 0)
                    break;
            }
            Console.WriteLine($"First number after 1000 divided by 97 is {i}");

            Console.ReadLine();
        }
    }
}
