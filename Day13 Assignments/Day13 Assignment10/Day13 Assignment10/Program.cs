using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment10
{
    //Authir: Bhanu Prakash Reddy
    //WACP for Recursion
    internal class Program
    {
        class Factorial
        {
            public int Fact(int number)
            {
                if (number == 1)
                    return 1;
                else
                    return number * Fact(number - 1);
            }
        }

        static void Main(string[] args)
        {
            int input;

            Console.Write("Enter number : ");
            input = Convert.ToInt32(Console.ReadLine());

            Factorial fact =new Factorial();
            Console.WriteLine($"Factorial is {fact.Fact(input)}");

            Console.ReadLine();
        }
    }
}
