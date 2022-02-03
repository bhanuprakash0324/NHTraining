using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTasks
{
    //Author.Bhanu Prakash Reddy
      //2. Write C# program to read two numbers from use and print
     // a.sum of two numbers
    // b.difference of two numbers
   // c.product of two numbers
  // d.division of two numbers.

    class MathsTask
    {
        private int a;
        private int b;

        public void ReadInput()
        {
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Addition of two numbers
        /// </summary>
        /// <returns>Sum</returns>
        public int AddNumbers()
        {
            return a + b;
        }
        /// <summary>
        /// Subtraction of two numbers
        /// </summary>
        /// <returns>Sub</returns>

        public int SubNumbers()
        {
            return a - b;  
        }
        /// <summary>
        /// Product of two numbers
        /// </summary>
        /// <returns>Product</returns>

        public int MultiplyNumbers()
        {
            return a * b;
        }
        /// <summary>
        /// Divison of two numbers
        /// </summary>
        /// <returns>Division</returns>
         
        public int Dividenumbers()
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsTask mt = new MathsTask();
            mt.ReadInput();
            Console.WriteLine(mt.AddNumbers());
            Console.WriteLine(mt.SubNumbers());
            Console.WriteLine(mt.MultiplyNumbers());
            Console.WriteLine(mt.Dividenumbers());

            Console.ReadLine();
        }
    }
}
