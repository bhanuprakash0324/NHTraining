using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibraray;

namespace BusinessLogicLibraray
{
    //-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-
    //Author: Bhanu Prakash Reddy
    //WACP for Employee Business Logic Layer
    //-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-
    public class EmployeesBLL
    {
        public static bool AddEmployee(int empID, string empName, int empSalary, int empAge)
        {
            var result = EmployeesDAL.AddEmployee(empID, empName, empSalary, empAge);
            return result;
        }

        public static List<string> FindEmployeesByID(int ID)
        {
            var result = EmployeesDAL.FindEmployeesByID(ID);
            return result;
        }

        public static List<string> FindEmployeesByName(string name)
        {
            var result = EmployeesDAL.FindEmployeesByName(name);
            return result;
        }

        public static string[] FindAllEmployees()
        {
            var result = EmployeesDAL.FindAllEmployees();
            return result;
        }
    }
}
