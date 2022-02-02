using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Class_Id_and_Name_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){id=11,name="HR Deapartment",empcount=45},
                new Department(){id=12,name="Developer Department",empcount=94},
                new Department(){id=13,name="QA Department",empcount=75},
                new Department(){id =14,name="BA Department",empcount=42},
                new Department(){id =15,name="Production Department",empcount=51}
            };

            //For loop
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].empcount > 50)
                    Console.WriteLine($"Department Id: {departments[i].id},Department Name: {departments[i].name}");
            }

            //For Each Loop

            foreach (var d in departments)
            {
                if (d.empcount > 50)
                    Console.WriteLine($"Department Id: {d.id},Department Name: {d.name}");
            }

            //Lambda Expression
            departments.Where(d => d.empcount > 50).ToList().ForEach(d => Console.WriteLine($"Department Id: {d.id},Department Name: {d.name}"));

            //Linq query

            var result = from d in departments
                         where d.empcount > 50
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"Department Id: {d.id},Department Name: {d.name}"));

            Console.ReadLine();

        }
    }
}
