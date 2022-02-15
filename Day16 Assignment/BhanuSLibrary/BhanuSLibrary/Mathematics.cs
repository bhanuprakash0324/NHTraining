using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhanuSLibrary
{

    public partial class Mathematics
    {
        public int input;
        /// <summary>
        /// Read data from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter any Number: ");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Calculating factorial
        /// </summary>
        /// <returns>Factorial of a number</returns>
        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}


