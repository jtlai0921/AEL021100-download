using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_3
{
    class Circle
    {
        public int radius;
        public const float PI = 3.14F;
        public static int count;

        public static void showPI()
        {
            Console.WriteLine(PI);
        }

        public void showArea(int r)
        {
            radius = r;
            Console.WriteLine(PI * radius * radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle.showPI();                    //透過類別的名稱呼叫靜態方法
            c1.showArea(10);                    //透過物件呼叫案例方法
            Console.ReadLine();
        }
    }
}
