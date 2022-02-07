using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics_class_with_static_methods
{
    class Mathematics
    {
        public static int Add(int a,int b)
        {
            Console.Write("Sum of two numbers : ");
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            Console.Write("Subtraction of two numbers : ");
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            Console.Write("Multiply of two numbers : ");
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(6,4));
            Console.WriteLine(Mathematics.Sub(8,4));
            Console.WriteLine(Mathematics.Mul(3,8));

            Console.ReadLine();


        }
    }
}
