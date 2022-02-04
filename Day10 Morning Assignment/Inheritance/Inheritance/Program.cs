using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Author: Bhanu Prakash Reddy
    // Write a code for Single Inheritance
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
        /// TotalMaths
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>sum,sub,Multiplication</returns>
            public int Mul(int a, int b)
            {
                return (a * b);
            }
            
        }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalMaths tm = new TotalMaths();
            Console.WriteLine(tm.Add(4, 5));
            Console.WriteLine(tm.Sub(4, 5));
            Console.WriteLine(tm.Mul(4, 5));
            
            Console.ReadLine();

        }
    }
}
