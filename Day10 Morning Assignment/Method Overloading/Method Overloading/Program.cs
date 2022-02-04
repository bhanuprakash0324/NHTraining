using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        //Author: Bhanu Prakash Reddy
        //Write a simple code for method overloading
        class Algebra
        {
            /// <summary>
            /// adding two numbers
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns>a+b</returns>
            public int Add(int a, int b)
            {
                return a + b;
            }
            /// <summary>
            /// adding three numbers
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <param name="c"></param>
            /// <returns>a+b+c</returns>
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            /// <summary>
            /// adding four numbers 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <param name="c"></param>
            /// <param name="d"></param>
            /// <returns>a+b+c+d</returns>
            public int Add(int a, int b, int c, int d)
            {
                return a + b + c + d;
            }
        }
        static void Main(string[] args)
        {
            Algebra al = new Algebra();
            Console.WriteLine(al.Add(34, 46));
            Console.WriteLine(al.Add(24, 76, 43));
            Console.WriteLine(al.Add(12, 23, 64, 77));

            Console.ReadLine();

        }
    }
}
