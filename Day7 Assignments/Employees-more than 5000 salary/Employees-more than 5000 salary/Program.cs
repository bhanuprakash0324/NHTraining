using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_more_than_5000_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
            {
                new Employee(){id=1, name="Bhanu", salary=2500},
                new Employee(){id=2, name="Krishna", salary=6000},
                new Employee(){id=3, name="RamaKrishna", salary=7500},
                new Employee(){id =4, name="Chaitanya", salary=2000},
                new Employee(){id=5, name="Suresh", salary=8000}
            };
            // for loop
            for (int i = 0; i < employee.Length; i++)
            {
                if(employee[i].salary >=5000)
                     Console.WriteLine($"Id={employee[i].id},Name={employee[i].name},Salary={employee[i].salary}");
            }


            //foreach loop
            foreach (var e in employee)
            {
                if(e.salary >=5000)
                Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}");
            }
            //lambda Expression

            employee.ToList().Where(e => e.salary >=5000).ToList().ForEach(e => Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}"));

            Console.ReadLine();


        }
    }
}
