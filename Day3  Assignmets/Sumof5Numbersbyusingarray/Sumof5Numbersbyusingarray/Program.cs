using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumof5Numbersbyusingarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avj;
            int[] data = new int[5];

            
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Enter Number: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < data.Length; i++)
                sum = sum + data[i];

            avj = sum / data.Length;

            
            Console.WriteLine($"Sum of all the numbers in an array is {sum} and Average is {avj}");

            Console.ReadLine();
        }
    }
}
