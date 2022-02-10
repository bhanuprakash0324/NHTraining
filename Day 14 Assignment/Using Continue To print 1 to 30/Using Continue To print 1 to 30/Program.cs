using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Continue_To_print_1_to_30
{
    //Autjor: Bhanu Prakash reddy
    //WACP using continue to print numberes
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Skipping numbers divisible by 3 : ");
                
            for(i=1;i<=30;i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}
