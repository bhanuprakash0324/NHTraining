using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override_Keyword
{
    //Author: Bhanu Prakash Reddy
    //Write a simple code using virtual and override keyword
    internal class Program
    {
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
            public virtual void PrintGM()
            {
                Console.WriteLine("Good Morning");
            }

        }
        class HindiMessage : EnglishMessage
        {
            /// <summary>
            /// Print Subh Prabhaat
            /// </summary>
            public override void PrintGM()
            {
                Console.WriteLine("Subh Prabhaat");
            }

        }

        static void Main(string[] args)
        {

            EnglishMessage em = new EnglishMessage();
            em.PrintHi();
            em.PrintHello();
            em.PrintGM();

            HindiMessage hm = new HindiMessage();
            hm.PrintHi();
            hm.PrintHello();
            hm.PrintGM();

            Console.ReadLine();

        }
    }
}
