using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_5
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();       //建立物件時會自動執行建構函式
            Circle c2 = new Circle();       //建立物件時會自動執行建構函式
            Console.WriteLine(Circle.count);
            Console.ReadLine();
        }
    }
}
