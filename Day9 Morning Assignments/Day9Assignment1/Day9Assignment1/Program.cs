using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//   Author: Bhanu Prakash Reddy
//    Purpose: Write a C# program to read input from user and print
//                     1. factorial of a number
//                     2. factors of a number
//                    3. check if it prime or not
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

namespace Day9Assignment1
{
    class Mathsoperations
    {
        private int input;

        public void ReadInput()
        {
            Console.WriteLine("Enter Number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// factorial of a number
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            for(int i=1; i <= input; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
        /// <summary>
        /// factors of a number
        /// </summary>

        public void PrintFactors()
        {
            for(int i=1;i<=input;i++)
            {
                if(input%i==0)
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// prime number or not
        /// </summary>
        /// <returns>Is prime</returns>

        public bool IsPrime()
        {
            int count = 0;
            for(int i=1;i <= input;i++)
            {
                if (input % i == 0)
                    count++;
            }
            if(count == 2)
                return true;
            else
                return false;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mathsoperations obj = new Mathsoperations();
            obj.ReadInput();
            obj.Factorial();
            obj.PrintFactors();
            if(obj.IsPrime())
                Console.WriteLine("Input is prime number");
            else
                Console.WriteLine("input is not prme number");

            Console.ReadLine();
        }
    }
}
