using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ServiceReference1;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj=new WebService1SoapClient();

            Console.WriteLine($"The factorial of the number is {obj.Factorial(4)}");
            Console.WriteLine($"Sum of the numbers is {obj.Add(4,6)}");
            Console.WriteLine($"Multiplication of the numbers is {obj.Mul(7,3)}");
            Console.WriteLine($"Divison of the numbers is {obj.Div(30,10)}");

            Console.ReadLine();
        }
    }
}
