using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable_OOPs
{
    //Author:Bhanu Prakash Reddy
    //WACP for Multiplcation Table using OOPs
    class Table
    {
        int a;

        /// <summary>
        /// ReadData
        /// </summary>
        public void ReadTable()
        {
            Console.WriteLine("Enter Number: ");
            a=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Printdata
        /// </summary>
        public void PrintTable()
        {
            for(int i = 1; i<=10;i++)

                Console.WriteLine($"{a}*{i}={a*i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Table t= new Table();
            t.ReadTable();
            t.PrintTable();

            Console.ReadLine();
        }
    }
}
