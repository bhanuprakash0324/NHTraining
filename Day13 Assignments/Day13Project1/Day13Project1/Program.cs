using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project1
{
    //Author: Bhanu Prakash Reddy
    //WACP for 2D Array of size(2,2) using nested for loop
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,]
            {
                {5,8},
                {16,14}
            };
            //nested for loop
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
