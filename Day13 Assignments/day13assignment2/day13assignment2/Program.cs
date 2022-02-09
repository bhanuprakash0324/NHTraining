using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13assignment2
{
    //Author:Bhanu Prakash Reddy
    //WACP for 2D array of size (3,2) and initialize in same line and print using nested for loop 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 4, 8 }, { 12, 18 }, { 22, 36 } };

            //Nested for loop
            for(int i = 0;i<data.GetLength(0);i++)
            {
                for (int j=0;j<data.GetLength(1);j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
