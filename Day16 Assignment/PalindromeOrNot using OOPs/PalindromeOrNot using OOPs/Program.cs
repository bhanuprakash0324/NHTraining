using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeOrNot_using_OOPs
{
    //Author:Bhanu Prakash Reddy
    //Wacp For plindrome or not using opps
    internal class Program
    {
        class Palindrome
        {
            int temp, num, rem, sum = 0;

            /// <summary>
            /// User input
            /// </summary>
            public void ReadNumber()
            {
                Console.WriteLine("Enter Number");
                num=Convert.ToInt32(Console.ReadLine());
            }

            /// <summary>
            /// Print Palindrome or not
            /// </summary>
            public void PrintPalindrome()
            {
                temp = num;
                while(num>0)
                {
                    rem = num % 10;
                    sum = (sum * 10) + rem;
                    num = num / 10;

                }
                if(temp == sum)
                    Console.WriteLine($"{temp} is Palindrome");
                else
                    Console.WriteLine($"{temp} is not Palindrome");
            }
        }
        static void Main(string[] args)
        {
            Palindrome p=new Palindrome();
            p.ReadNumber();
            p.PrintPalindrome();

            Console.ReadLine();
        }
    }
}
