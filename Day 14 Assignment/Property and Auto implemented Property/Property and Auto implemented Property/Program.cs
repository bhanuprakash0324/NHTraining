using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_and_Auto_implemented_Property
{
    // Author: Bhanu Prakash Reddy
    //WACP using property and auto implemented property
    class Speed
    {
        private int distance;
        private int time;

        //Normal Properties
        public int Distance
        {
            set 
            {
                distance = value;
            }
        }
        public int Time
        {
            set
            {
                time = value;
            }
        }
        public int GetSpeed
        {
            get
            {
                return distance / time;
            }
        }
        //Auto implemented Property
        public int Velocity
        {
            get
            {
                return distance / time;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Speed s = new Speed();
            s.Distance = 90;
            s.Time = 10;
            Console.WriteLine($"Speed is {s.GetSpeed}");

            Console.ReadLine();
        }
    }
}
