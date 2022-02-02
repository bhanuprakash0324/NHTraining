using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_with__8_values
{
    internal class Program
    {
        //Author : Bhanu Prakash Reddy Chilukuri
        //Purpose : Declare and intialize a list with a 8 values. write for for loop, foreach,lambda,LINQ query    `
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 18, 25, 85, 44, 64, 28, 108, 55 };

            //Even numbers using for loop
            for(int i=0;i<data.Count;i++)
            {
                if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            //using foreachloop
            foreach (var d in data)
            {

                if (d % 2 == 0)
                    Console.WriteLine(d);
            }
            //lamda expression
            data.Where(d=>d%2==0).ToList().ForEach(d=>Console.WriteLine(d));

            //LINQ Query

            var result=from d in data
                       where d%2==0
                       select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();


        }
    }
}
