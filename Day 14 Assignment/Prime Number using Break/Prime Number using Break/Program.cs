using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_using_Break
{
    //Author: Bhanu Prakash Reddy
    //WACP for prime number using break;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.WriteLine("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i =2;i <= n;i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine($"{n} is a Prime Number");
            else
                Console.WriteLine($"{n} is not a prime Number");

            Console.ReadLine();
        }
    }
}
