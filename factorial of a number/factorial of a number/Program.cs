using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n;
            Console.WriteLine("Enter the fact number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
                fact = fact * i;
            Console.WriteLine("factorial of number : " + fact);
            Console.ReadLine();
        }
    }
}
