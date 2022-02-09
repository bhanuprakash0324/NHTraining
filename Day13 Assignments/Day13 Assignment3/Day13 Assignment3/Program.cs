using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment3
{
    //Author: Bhanu Prakash Reddy
    // WACP for finding the trace of the array of size (3,3)
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 4, 8, 9 }, { 15, 23, 67 }, { 14, 32, 18 } };
            int sum = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                //Trace of the Matrix
                {
                    if (i == j)
                        sum += data[i, j];
                }
            }
            Console.WriteLine($"Trace of the matrix is {sum}");
            Console.ReadLine();
        }        
    }
}
