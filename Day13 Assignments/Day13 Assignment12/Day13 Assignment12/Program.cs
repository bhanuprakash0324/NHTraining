using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment12
{
    //Author: Bhanu Prakash Reddy
    //WACP for Queue
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(11);
            data.Enqueue(21);
            data.Enqueue(31);

            for (int i = 0; i <= data.Count; i++)
                Console.WriteLine($"Element Removed {data.Dequeue()}");

            Console.WriteLine($"Element peek {data.Peek()}");

            Console.ReadLine();

        }
    }
}
