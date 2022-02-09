using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy13Assignment5
{
    //Author : Bhanu Prakash Reddy
    //WACP sum of the matrices
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data1 = new int[2, 2];
            int[,] data2 = new int[2, 2];
            int[,] data3 = new int[2, 2];
            //Read Values from user
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                for (int j = 0; j < data1.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value at ({i},{j}) : ");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print data1 array
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                for (int j = 0; j < data1.GetLength(1); j++)
                {
                    Console.Write(data1[i, j] + " ");
                }
                Console.Write("\n");
            }

            //read value from user
            for (int i = 0; i < data2.GetLength(0); i++)
            {
                for (int j = 0; j < data2.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value at ({i},{j}) : ");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print data2 array
            for (int i = 0; i < data2.GetLength(0); i++)
            {
                for (int j = 0; j < data2.GetLength(1); j++)
                {
                    Console.Write(data2[i, j] + " ");
                }
                Console.Write("\n");
            }

            //sum of the two matrices
            for (int i = 0; i < data3.GetLength(0); i++)
            {
                for (int j = 0; j < data3.GetLength(1); j++)
                {
                    int sum = data1[i,j] + data2[i,j];
                    data3[i,j] = sum;
                }
            }
            Console.WriteLine($"Sum of tho Matrices :");
            for (int i = 0; i < data3.GetLength(0); i++)
            {
                for (int j = 0; j < data3.GetLength(1); j++)
                {
                    Console.Write($"{data3[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
            
        }
        
    }
}
