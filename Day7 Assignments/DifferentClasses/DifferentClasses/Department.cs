using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClasses
{
    internal class Department
    {
        private int dept_id;
        private string dept_name;
        private int dept_strength;

        public void ReadDepartment()
        {
            Console.WriteLine("Enter dept_id: ");
            dept_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter dept_name: ");
            dept_name = (Console.ReadLine());

            Console.WriteLine("Enter dept_strength: ");
            dept_strength = Convert.ToInt32(Console.ReadLine());
        }



        public void PrintDepartment()
        {
            Console.WriteLine($"Dept_Id={dept_id},Dept_Name={dept_name},Dept_Strength={dept_strength}");
        }
        

    }
}
