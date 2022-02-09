using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13assignment11
{
    //Author: Bhanu Prakash Reddy
    //WACP for Stack
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(11);
            data.Push(12);
            data.Push(13);

            for (int i = 0; i <= data.Count; i++)
                Console.WriteLine($"Element POP {data.Pop()}");
            Console.WriteLine($"Element peek {data.Peek()}");

            Console.ReadLine();
        }
    }
}
