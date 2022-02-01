using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_more_than_5000_salary
{
    internal class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());


        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={id},Name={name},Salary={salary}");
        }

    }
}
