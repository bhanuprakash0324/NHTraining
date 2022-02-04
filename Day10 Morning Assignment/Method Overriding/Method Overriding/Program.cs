using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    // Author: Bhanu Prakash Reddy
    // Write a simple code for Method Overriding
    class EnglishMessage
    {
        /// <summary>
        /// Print Hi
        /// </summary>
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        /// <summary>
        /// Print Hello
        /// </summary>
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        /// <summary>
        /// Print Good Morning
        /// </summary>
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }

    }
    class TeluguMessage : EnglishMessage
    {
        /// <summary>
        /// Print Subhodhayam
        /// </summary>
        public new void PrintGM()
        {
            Console.WriteLine("Subhodhaym");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EnglishMessage em = new EnglishMessage();
            em.PrintHi();
            em.PrintHello();
            em.PrintGM();

            TeluguMessage tm = new TeluguMessage();
            tm.PrintHi();
            tm.PrintHello();
            tm.PrintGM();

            Console.ReadLine();
        }
    }
}
