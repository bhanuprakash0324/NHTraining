using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHello_using_OOPS
{
    //Author: Bhanu Prakash Reddy
    //WACP to print hello using object oriented program
    class Message
    {
        public static void PrintHello()
        {
            Console.WriteLine(@" 
  _ _          __    __           _     _   _ 
    /\  /\___| | | ___    / / /\ \ \___  _ __| | __| | / \
   / /_/ / _ \ | |/ _ \   \ \/  \/ / _ \| '__| |/ _` |/  /
  / __  /  __/ | | (_) |   \  /\  / (_) | |  | | (_| /\_/ 
  \/ /_/ \___|_|_|\___( )   \/  \/ \___/|_|  |_|\__,_\/   
                      |/       ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Message.PrintHello();

            Console.ReadLine();
        }
    }
}
