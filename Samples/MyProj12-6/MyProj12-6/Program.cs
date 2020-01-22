using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_6
{
    class Circle
    {
        public int radius;
        public const float PI = 3.14F;
        public static int count;

        public Circle()
        {
            count++;
        }

        public Circle(int r)
        {
            count++;
            radius = r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(10);
            Console.WriteLine(Circle.count);
            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);
            Console.ReadLine();
        }
    }
}
