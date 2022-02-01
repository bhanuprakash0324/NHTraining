using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwith3publicvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { id = 1, name = "Bhanu", age = 24, salary = 25356 };
            Console.WriteLine($"id={employee.id},name={employee.name},age={employee.age},salary={employee.salary}");
            Console.ReadLine();
        }
       

        
    }
}
