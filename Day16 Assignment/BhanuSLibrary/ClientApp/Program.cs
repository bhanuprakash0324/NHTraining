using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicLibrary;
using BhanuSLibrary;


namespace ClientApp
{
    //Author:Bhanu Prakash Reddy
    //Wacp using two libraries in MyProject
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Mathematics2 m2 = new Mathematics2();
            Physics p = new Physics();
            m.ReadData();
            Console.WriteLine($"Factorial of a number is {m.GetFactorial()}");
            Console.WriteLine(m2.Add(2, 4));
            Console.WriteLine(Physics.FinalVelocity(4,5,5));

            Console.ReadLine();

        }
    }
}
