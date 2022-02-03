using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment3
{
    //Author: Bhanu Prakash Reddy
    //3. Create an employee class with below variables
   //id, name, salary, company
   //write methods to read data and print data

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public string company;

        /// <summary>
        /// Read employee data
        /// </summary>

        public void ReadData()
        {
            Console.WriteLine("Enter employee id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            name = (Console.ReadLine());
            Console.WriteLine("Enter employee salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            company = "NatinonsBenefits";
        }
        /// <summary>
        /// Print Employee data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Id: {id}, Name={name}, Salary={salary},Company={company}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadData();
            emp.PrintData();

            Console.ReadLine();

        }
    }
}
