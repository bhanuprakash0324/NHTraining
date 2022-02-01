using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelorNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any single character");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine($"the character {ch} is vowel");
                    break;
                default:
                    Console.WriteLine($"the character {ch} is not vowel");
                    break;

            }
            Console.ReadLine();


           
            
             

            
        }
    }
}
