using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_9
{
    public interface Shape
    {
        double Area(double X, double Y);
    }

    public class RightTriangle : Shape                          //宣告實作Shape介面的三角形類別
    {
        public double Area(double X, double Y)                  //提供Area() 方法的實作方式
        {
            return (X * Y) / 2;                                 //計算三角形面積 (底乘以高除以2)
        }
    }

    public class Rectangle : Shape                              //宣告實作Shape介面的矩形類別
    {
        public double Area(double X, double Y)                  //提供Area() 方法的實作方式
        {
            return (X * Y);                                     //計算矩形面積 (長乘以寬)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle obj1 = new RightTriangle();           //建立三角形類別的物件
            Rectangle obj2 = new Rectangle();                   //建立矩形類別的物件
            Console.WriteLine("底為20高為10的三角形面積為" + obj1.Area(20, 10));
            Console.WriteLine("長為20寬為10的矩形面積為" + obj2.Area(20, 10));
            Console.ReadLine();
        }
    }
}
