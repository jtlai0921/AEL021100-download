using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_1
{
    class Circle
    {
        public int radius;                          //宣告一個案例變數
        public const float PI = 3.14F;              //宣告一個常數
        public static int count;                    //宣告一個靜態變數
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();               //欲存取案例變數必須建立類別的物件
            c1.radius = 5;                          //透過物件將案例變數radius的值設定為5
            Console.WriteLine(c1.radius);           //透過物件將案例變數radius的值顯示出來
            Console.ReadLine();
        }
    }
}
