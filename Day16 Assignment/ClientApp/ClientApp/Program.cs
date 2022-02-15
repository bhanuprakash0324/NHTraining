using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BhanuLibrary_with_three_classes;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Add(4,5));
            Console.WriteLine(m.Sub(9, 5));


            int u = 6;
            int a = 4;
            int t = 3;

            Physics p = new Physics();
            var v = p.Finalvelocity(u,a,t);
            Console.WriteLine($"Final velocity is {v}");

            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetWater());



            Console.ReadLine();
        }
    }
}
