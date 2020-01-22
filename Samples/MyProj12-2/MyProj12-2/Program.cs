using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_2
{
    class Circle
    {
        public int radius;                              //宣告一個案例變數
        public const float PI = 3.14F;                  //宣告一個常數
        public static int count;                        //宣告一個靜態變數
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.PI);               //透過類別的名稱顯示常數PI的值
            Console.WriteLine(Circle.count);            //透過類別的名稱顯示靜態變數count的值
            Console.ReadLine();
        }
    }
}
