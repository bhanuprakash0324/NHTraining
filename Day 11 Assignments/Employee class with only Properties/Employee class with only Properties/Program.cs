using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class_with_only_Properties
{
    class Employee
    {
        public int Id
        { 
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }

        }
        public string Name 
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Designation
        {
            get
            {
                return Designation;
            }
            set
            {
                Designation = value;
            }
        }
        public int Salary 
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            Console.ReadLine();
        }
    }
}
