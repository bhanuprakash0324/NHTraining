using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClasswiththreevariablesandtwomethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee1 = new Employee();
           Employee employee2 = new Employee(); 
           Employee employee3 = new Employee();

            employee1.ReadEmployee();
            employee1.PrintEmployee();
            employee2.ReadEmployee();
            employee2.PrintEmployee();
            employee3.ReadEmployee();
            employee3.PrintEmployee();

            Console.ReadLine();
        }
    }
}
