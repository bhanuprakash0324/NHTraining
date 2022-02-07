using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    //Author: Bhanu Prakash Reddy
    //Write simple code to illustrate properties as discussed in class
    class Employee
    {
        public int id;
        public string name;
        public string designation;
        public int salary;
        /// <summary>
        /// Properties of Id
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        /// <summary>
        /// properties of Nmae
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// properties of Designation
        /// </summary>
        public string Designation
        {

            set
            {
                designation = value;
            }
                
        }
        /// <summary>
        /// Properties of salary
        /// </summary>
        public int Salary 
        {
            get
            {
                salary = (designation == "S") ? 30000 : 60000;
                return salary;
            }
            
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Designation = "S";
                Console.WriteLine($"Salary:{emp.Salary}");

                Console.ReadLine();
            }
        }
    }
}
