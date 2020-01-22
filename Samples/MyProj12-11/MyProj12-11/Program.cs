using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_11
{
    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        ~Point()
        {
            Console.WriteLine("這個物件即將被摧毀！");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 10);
            p1 = null;
            System.GC.Collect();
            Console.ReadLine();
        }
    }
}
