using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table__while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, input;
            Console.WriteLine("ENTER ANY NUMBER : ");
            input = Convert.ToInt32(Console.ReadLine());

            while (i<=10)
            {
                Console.WriteLine(input + "x" + i + "=" + input * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
