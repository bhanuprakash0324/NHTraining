using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Product_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[]
            {
                new Customer(){id=1, name="Bhanu", emailid="abc@gmail.com"},
                new Customer(){id=2, name="Krishna", emailid="cde@gmail.com"},
                new Customer(){id=3, name="RamaKrishna", emailid="def@gmail.com"},
                new Customer(){id=4, name="Chaitanya", emailid="fgh@gmail.com"},
                new Customer(){id=5, name="Suresh", emailid="ghi@gmail.com"}
            };
            Product[] product = new Product[]
            {
                new Product(){id=1, name="Tin", price=800},
                new Product(){id=2, name="Coke", price=700},
                new Product(){id=3, name="Sprite", price=400},
                new Product(){id=4, name="Plugbox", price=850},
                new Product(){id=5, name="Lays", price=900}
            };
            // for loop
            for (int i = 0; i < customer.Length; i++)
            {
                Console.WriteLine($"Id={customer[i].id},Name={customer[i].name},Emailid={customer[i].emailid}");

            }

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine($"Id={product[i].id},Name={product[i].name},price={product[i].price}");

            }
            //foreach loop
            foreach (var c in customer)
            {
                Console.WriteLine($"Id={c.id},Name={c.name},Emailid={c.emailid}");
            }
            
            foreach (var p in product)
            {
                Console.WriteLine($"Id={p.id},Name={p.name},Price={p.price}");
            }
            //lambda Expression
            customer.ToList().ForEach(c => Console.WriteLine($"Id={c.id},Name={c.name},Salary={c.emailid}"));

            product.ToList().ForEach(p => Console.WriteLine($"Id={p.id},Name={p.name},Salary={p.price}"));

            Console.ReadLine();






        }
    }
}
