using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibraray
{
    //-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-
    //Author: Bhanu Prakash Reddy
    //WACP for Employee Data Access Layer
    //-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-
    public static class EmployeesDAL
    {
        /// <summary>
        /// filepath for saved text file
        /// </summary>
        public static string filepath = "D:\\Employee Data\\Employee.txt";
        /// <summary>
        /// Adding Employee Details
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns>Employee Data</returns>
        public static bool AddEmployee(int empID, string empName, int empSalary, int empAge)
        {
            try
            {
                string empdetails = string.Concat(empID, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filepath, empdetails + Environment.NewLine);
                return true;

            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Finding empolyee data by using Id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>eEmployee Data</returns>

        public static List<string> FindEmployeesByID(int ID)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<string> employeesFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empdetails = employee.Split(',');
                if (Convert.ToInt32(empdetails[0]) == ID)
                {
                    isFound = true;
                    employeesFound.Add(employee);
                    break;
                }
            }
            return employeesFound;
        }
        /// <summary>
        /// Finding employee data by using name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Employee data</returns>

        public static List<string> FindEmployeesByName(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            List<string> employeesFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empdetails = employee.Split(',');
                if (empdetails[1].Contains(name))
                {
                    employeesFound.Add(employee);
                }
            }
            return employeesFound;
        }
        /// <summary>
        /// Dispalying All Employees Data
        /// </summary>
        /// <returns>All Employee Data</returns>

        public static string[] FindAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filepath);
            return allEmployees;
        }
    } 
}
