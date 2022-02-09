using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_assignment4
{
    // Author: Bhanu Prakash Reddy
    //WACP 2D array of size (2,2) and read values from user and print values
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            //Read Values from user
            for(int i=0; i<data.GetLength(0); i++)
            {
                for(int j=0; j<data.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value at ({i},{j}) : ");
                    data[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Print values
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i,j]+" ");

                }
                Console.Write("\n");

            }
            Console.ReadLine();

        }
    }
}
