﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Program
{
    //Author: Bhanu Prakash Reddy
    //6. Create Employee class with two constructors as discussed in the class
    internal class Program
    {
        class Employee
        {
            private int id;
            private string name;
            private int salary;

            public static string company = "NationsBenefits";

            /// <summary>
            /// Default Constructor
            /// </summary>

            public Employee()
            {
                this.id = 0;
                this.name = null;
                this.salary = 0;
            }

            /// <summary>
            /// User Define Constructor
            /// </summary>

            public Employee(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }

            /// <summary>
            /// Get input employee details 
            /// </summary>

            public void ReadData()
            {
                Console.Write("Enter Emloyee Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Emloyee Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Emloyee Salary: ");
                salary = Convert.ToInt32(Console.ReadLine());
            }

            /// <summary>
            /// Print the employee details
            /// </summary>
            public void Printdata()
            {
                Console.WriteLine($"Employee Id: {id}, Employee Name: {name}, Employee Salary: {salary}, Company name: {company}.");
            }
        }


        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadData();
            emp.Printdata();


            Employee emp1 = new Employee(22, "Bhanu", 5000);
            emp1.Printdata();

            Console.ReadLine();

        }
    }
}
