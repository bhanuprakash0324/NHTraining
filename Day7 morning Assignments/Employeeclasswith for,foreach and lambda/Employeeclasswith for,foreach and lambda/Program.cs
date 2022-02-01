using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeclasswith_for_foreach_and_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
            {
                new Employee(){id=1, name="Bhanu", salary=25356},
                new Employee(){id=2, name="Krishna", salary=20000},
                new Employee(){id=3, name="RamaKrishna", salary=17500},
                new Employee(){id =4, name="Chaitanya", salary=20000},
                new Employee(){id=5, name="Suresh", salary=18000}
            };
            // for loop
            for(int i = 0;i< employee.Length;i++)
            {
                Console.WriteLine($"Id={employee[i].id},Name={employee[i].name},Salary={employee[i].salary}");

            }
            //foreach loop
            foreach(var e in employee)
            {
                Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}");
            }
            //lambda Expression
            employee.ToList().ForEach(e => Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}"));
            Console.ReadLine();
        }   
    }
}
