using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance
{
    //Author: Bhanu Prakash Reddy
    // Write a code for multi level inheritnce
    class Algebra
    {
        /// <summary>
        /// Algebra
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>sum,sub</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class TotalMaths : Algebra
    {
        /// <summary>
        /// TotalMAths
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>sum,sub,Multiplication</returns>
        public int Mul(int a, int b)
        {
            return (a * b);
        }

    }
    class AdvMaths : TotalMaths
    {
        /// <summary>
        /// AdvMaths
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>sum,sub,Multiplication,Division</returns>
        public int Div(int a,int b)
        {
            return a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AdvMaths am = new AdvMaths();
            Console.WriteLine(am.Add(32, 6));
            Console.WriteLine(am.Sub(32, 6));
            Console.WriteLine(am.Mul(32, 6));
            Console.WriteLine(am.Div(32, 6));

            Console.ReadLine();


        }
    }
}
