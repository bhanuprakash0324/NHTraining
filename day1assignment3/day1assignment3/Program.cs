using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, power = 1;

            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second NUmber");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num2; i++)
                power = power * num1;

            Console.WriteLine("power of num1 per num2 ="+power);

            Console.ReadLine();
        }
    }
}
