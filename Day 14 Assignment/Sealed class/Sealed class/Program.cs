using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{
    //Author: Bhanu Prakash Reddy
    //WACP using the Sealed Class
    sealed class Player
    {
        private string playername;
        private int jerseynumber;
        
        /// <summary>
        /// Reading Player Information
        /// </summary>
        public void ReadPlayer()
        {
            Console.WriteLine("Enter Player Name : ");
            playername = Console.ReadLine();
            Console.WriteLine("Enter Jersey Number : ");
            jerseynumber = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Printing Player information
        /// </summary>
        public void PrintPlayer()
        {
            Console.WriteLine($"Name of the Player is {playername}");
            Console.WriteLine($"Jersey Number of the Player is {jerseynumber} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.ReadPlayer();
            p.PrintPlayer();

            Console.ReadLine();
            
        }
    }
}
