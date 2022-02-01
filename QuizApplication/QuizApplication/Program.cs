using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Hi {0}, Welocome to quiz by Bhanu",name);
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("1. Which two countries compete for cricket's Ashes?");
            Console.WriteLine("1. India vs Pakistan  2.Australia vs England  3.Srilanka vs Bangladesh  4.India va Srilanka");
            Console.WriteLine("Enter you choice: ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("2. Which cricket team is named the Baggy Greens?");
            Console.WriteLine("1.Australia   2.India    3.England    4.Srilanka");
            Console.WriteLine("Enter your choice: ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("3. Where did cricket orginate from?");
            Console.WriteLine("1.West Indies   2.India    3.England    4.Australia");
            Console.WriteLine("Enter your choice: ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("4. How long do test cricket matches usualy go on for?");
            Console.WriteLine("1.5 hours   2.5 days    3.1 day    4.2 days");
            Console.WriteLine("Enter your choice: ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("5. Cricketer who scored most centuries in all formats?");
            Console.WriteLine("1.Ricky Ponting   2.Mahela Jayawardane    3.Sachin Tendulkar    4.Brain Lara");
            Console.WriteLine("Enter your choice: ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.WriteLine("*************************************************************************************");

            if (score >= 60)
                Console.WriteLine("Congratulations {0}, you got {1}% in this quiz", name, score);
            else
                Console.WriteLine("Sorry {0}, you got only {1}%, Better luck next time", name, score);
            Console.WriteLine("*************************************************************************************");

            Console.ReadLine(); 







        }
    }
}
