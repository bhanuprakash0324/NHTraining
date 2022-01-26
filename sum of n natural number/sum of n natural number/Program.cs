using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("Enter thr nth number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
                sum = sum + i;
            Console.WriteLine("sum of the n numbers : " + sum);
            Console.ReadLine();
        }
    }
}
