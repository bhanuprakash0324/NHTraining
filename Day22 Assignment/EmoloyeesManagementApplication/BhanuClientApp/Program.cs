using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibraray;

namespace BhanuClientApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int s;
            string choice;

            do
            {
                Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");

                Console.WriteLine("1. Add Employee : ");
                Console.WriteLine("2. Search Employee Details by Id : ");
                Console.WriteLine("3. Search Employee Details by Name : ");
                Console.WriteLine("4. Display All Employee Details : ");
                Console.WriteLine("Enter your Choice");
                s = Convert.ToInt32(Console.ReadLine());
                switch (s)

                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        FindEmployeesByID();
                        break;
                    case 3:
                        FindEmployeesByName();
                        break;

                    case 4:
                        FindAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        break;

                }
                Console.WriteLine("Do you want to continue(y/n):");
                choice = Console.ReadLine();
            }
            while (choice.Equals("y"));
            
        }
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;

            Console.WriteLine("Enter Employee Id: ");
            id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            var empData = EmployeesBLL.AddEmployee(id, name, salary, age);

            if(empData)
                Console.WriteLine("Data Added Sucessfully");
            else
                Console.WriteLine("Enter valid data");

        }

        public static void FindEmployeesByID()
        {
            int id;
            Console.WriteLine("Enter Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());

            var empData = EmployeesBLL.FindEmployeesByID(id);

            if(empData.Count==0)
                Console.WriteLine($"No data exists in this {id}");
            else
            {
                empData.ForEach(emp => Console.WriteLine(emp));
            }

        }

        public static void FindEmployeesByName()
        {

            string name;
            Console.WriteLine("Enter Employee Name : ");
            name = Console.ReadLine();

            var empData = EmployeesBLL.FindEmployeesByName(name);

            if (empData.Count == 0)
                Console.WriteLine($"No data exists in this {name}");
            else
            {
                empData.ForEach(emp => Console.WriteLine(emp));
            }

        }

        public static void FindAllEmployees()
        {
            var empData = EmployeesBLL.FindAllEmployees();

            foreach(var emp in empData)
                Console.WriteLine(emp);

        }
    }
}
