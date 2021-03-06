using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_Program
{
    //Author:Bhanu Prakash Reddy
    //Write a simple program using finally
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int fn, sn, div;
                Console.WriteLine("Enter First number: ");
                fn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                sn = Convert.ToInt32(Console.ReadLine());
                div = fn / sn;
                Console.WriteLine($"Answer ={div}");
            }
            //Overflowexception
            catch (OverflowException)
            {
                Console.WriteLine($"Enter Number between {int.MinValue} and {int.MaxValue}");
            }
            //dividebyzeroexception
            catch (DivideByZeroException)
            {
                Console.WriteLine("Enter any number other than zero in second number");
            }
            //formatexception
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers");
            }
            //superexception
            catch (Exception)
            {
                Console.WriteLine("Contact abc@gmail.com");
            }
            //Finally
            finally
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n Program by Bhanu");
                Console.ReadLine();
            }

           
        }
    }
}
    