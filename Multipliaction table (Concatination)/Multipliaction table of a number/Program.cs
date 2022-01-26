using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipliaction_table_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + n * i);
            }
            Console.ReadLine();
        }

    }
}

