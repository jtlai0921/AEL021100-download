using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_8
{
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 10);
            Point p2 = new Point(p1);
            Console.WriteLine("p1.x的值為" + p1.x);
            Console.WriteLine("p1.y的值為" + p1.y);
            Console.WriteLine("p2.x的值為" + p2.x);
            Console.WriteLine("p2.y的值為" + p2.y);
            Console.ReadLine();
        }
    }
}
