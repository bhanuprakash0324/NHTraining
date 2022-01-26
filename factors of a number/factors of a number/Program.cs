using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factors_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
