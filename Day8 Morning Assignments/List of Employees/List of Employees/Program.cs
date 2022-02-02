using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){id=11,name="Bhanu",salary=6000},
                new Employee(){id=12,name="krishna",salary=7000},
                new Employee(){id=13,name="Raja",salary=4000},
                new Employee(){id =14,name="Fareed",salary =4500}
            };

            //For loop
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Employee Id: {employees[i].id},Employee Name: {employees[i].name},Employee Salary: {employees[i].salary}");
            }
            //For Each Loop

            foreach(var e in employees)
            {
                Console.WriteLine($"Employee Id: {e.id},Employee Nmae: {e.name},Employee Salary: {e.salary}");
            }

            //Lambda Expression
            employees.ForEach(e => Console.WriteLine($"Employee Id: {e.id},Employee Nmae: {e.name},Employee Salary: {e.salary}"));

            //Linq query

            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"Employee Id: {e.id},Employee Nmae: {e.name},Employee Salary: {e.salary}"));

            Console.ReadLine();

            

        }
    }
}
