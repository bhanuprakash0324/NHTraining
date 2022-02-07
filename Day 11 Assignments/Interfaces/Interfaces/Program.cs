using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Author:Bhanu Prakash reddy
    //Write a code using interfaces using Ishape
    interface IShape
    {
        int CalPerimeter();
        int CalArea();
    }
    class Circle : IShape
    {
        int radius;
        /// <summary>
        /// Reading radius
        /// </summary>
        public void ReadRadius()
        {
            Console.WriteLine("Enter Radius of the Circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Calculating Area
        /// </summary>
        /// <returns>Area</returns>
        public int CalArea()
        {
            Console.Write("Area of the circle : ");
            return 22 * radius * radius / 7;
        }
        /// <summary>
        /// calculating perimeter
        /// </summary>
        /// <returns>perimeter</returns>
       public int CalPerimeter()
        {
            Console.Write("Perimeter of the circle : ");
            return 2 * 22 * radius / 7;
        }
    }
    class Square : IShape
    {
        int side;

        /// <summary>
        /// Reading side of Square
        /// </summary>
        public void ReadSide()
        {
            Console.WriteLine("Enter side of the square:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalArea()
        {
            Console.Write("Area of the Square : ");
            return side * side;
        }

        public int CalPerimeter()
        {
            Console.Write("Perimeter of the Square : ");
            return 4 * side;
        }
    }
    class Rectangle : IShape
    {
        int length;
        int breath;
        /// <summary>
        /// Reading length and breath of rectangle
        /// </summary>
        public void ReadRectangle()
        {
            Console.WriteLine("Enter the length of the Rectangle:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breath of the Rectangle:");
            breath = Convert.ToInt32(Console.ReadLine());
        }

        public int CalArea()
        {
            Console.Write("Area of the Rectangle : ");
            return length * breath;
        }

        public int CalPerimeter()
        {
            Console.Write("Perimeter of the Reactangle : ");
            return 2 * (length + breath);
        }
    }
    class Traingle : IShape
    {
        int b;
        int height;
        int c;
        /// <summary>
        /// reading sides of triangle
        /// </summary>
         public void ReadTriangle()
        {
            Console.WriteLine("Enter the Base of the Triangle: ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the Triangle: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third side of the Trainglr: ");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public int CalArea()
        {
            Console.Write("Area of the Triangle : ");
            return b * height / 2;
        }

        public int CalPerimeter()
        {
            Console.WriteLine("Perimeter of the Traingle : ");
            return b + height + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalArea());
            Console.WriteLine(c.CalPerimeter());
            Console.WriteLine();
            Square s = new Square();    
            s.ReadSide();
            Console.WriteLine(s.CalArea());
            Console.WriteLine(s.CalPerimeter());
            Console.WriteLine();
            Rectangle r = new Rectangle();
            r.ReadRectangle();
            Console.WriteLine(r.CalArea());
            Console.WriteLine(r.CalPerimeter());
            Console.WriteLine();
            Traingle t = new Traingle();
            t.ReadTriangle();
            Console.WriteLine(t.CalArea());
            Console.WriteLine(t.CalPerimeter());

            Console.ReadLine();
        }
    }
}
