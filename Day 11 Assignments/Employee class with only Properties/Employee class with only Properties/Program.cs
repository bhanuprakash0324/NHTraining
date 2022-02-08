using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class_with_only_Properties
{
    class Employee
    {
        string designation;
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
            

            set
            {
                designation = value;
            }
        }
        public int Salary 
        {
            
            get
            {
                return (designation == "S") ? 30000 : 60000;
                
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Designation = "M";
            Console.WriteLine($"Salary : {emp.Salary}");
            Console.ReadLine();
        }
    }
}
