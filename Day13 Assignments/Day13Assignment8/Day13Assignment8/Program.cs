using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment8
{
    //Author: Bhanu Prakash Reddy
    //WACP for jagged array
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];

            names[0] = new char[] { 'K', 'O', 'B', 'E' };
            names[1] = new char[] { 'L', 'E', 'B', 'R', 'O', 'N' };
            names[2] = new char[] { 'J', 'O', 'R', 'D', 'O', 'N' };

            //Array elements
            for (int i = 0;i<names.Length;i++)
            {
                Console.Write($"Name at position {i} : ");
                for(int j=0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
