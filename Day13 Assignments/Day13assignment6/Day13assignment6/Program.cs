using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13assignment6
{
    //Author: Bhanu Prakash Reddy
    // WACP for the product of two matrices
    internal class Program
    {
        static void Main(string[] args)
        {
            int fm1, fm2, sm1, sm2;
            //Read Data
            Console.WriteLine("Enter Row size of First Matrix: ");
            fm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter colomn size of First Matrix: ");
            fm2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Row size of Second Matrix: ");
            sm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter colomn size of Second Matrix: ");
            sm2 = Convert.ToInt32(Console.ReadLine());

            int[,] firstmatrix = new int[fm1, fm2];
            int[,] secondmatrix = new int[sm1, sm2];
            int[,] productmatrix = new int[fm1, sm2];

            //first matrix
            for(int i = 0;i<fm1;i++)
            {
                for(int j = 0;j<fm2;j++)
                {
                    Console.Write($"Enter number at ({i},{j}): ");
                    firstmatrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i<fm1;i++)
            {
                for(int j =0;j<fm2;j++)
                {
                    Console.Write($"{firstmatrix[i, j]} ");
                }
                Console.Write("\n");
            }

            //second matrix
            for (int i = 0; i < sm1; i++)
            {
                for (int j = 0; j < sm2; j++)
                {
                    Console.Write($"Enter number at ({i},{j}): ");
                    secondmatrix[i,j]= Convert.ToInt32(Console.ReadLine());
                }
                
            }

            for (int i=0;i<sm1;i++)
            {
                for(int j=0;j<sm2;j++)
                {
                    Console.Write($"{secondmatrix[i, j]} ");
                }
                Console.Write("\n");
            }

            //product matrix
            if(fm2 != sm1)
            {
                Console.WriteLine("Product of Matrix is not possible");
            }
            else
            {
                for (int i = 0; i < fm1; i++)
                {
                    for (int j = 0; j < sm2; j++)
                    {
                        productmatrix[i, j] = 0;
                        for(int k= 0; k < fm2; k++)
                        {
                            productmatrix[i, j] += firstmatrix[i, k] * secondmatrix[k, j];
                        }
                    }
                }
                Console.WriteLine("Product of the two matrix: ");

                for(int i=0;i<fm1;i++)
                {
                    for(int j=0;j<sm2;j++)
                    {
                        Console.Write($"{productmatrix[i, j]} ");
                    }
                    Console.Write("\n");
                }
                Console.ReadLine();

            }
        }
    }
}
