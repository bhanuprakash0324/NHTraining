using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ReadCustomer();
            customer1.PrintCustomer();

            Product product1 = new Product();
            product1.ReadProducts();
            product1.PrintProducts();

            Seller seller = new Seller();
            seller.ReadSeller();    
            seller.PrintSeller();

            Department department = new Department();
            department.ReadDepartment();
            department.PrintDepartment();

            Console.ReadLine();
        }
    }
}
