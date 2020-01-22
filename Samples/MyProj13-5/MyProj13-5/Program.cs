using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_5
{
    public abstract class Shape
    {
        public double Line;

        public Shape(double L)
        {
            Line = L;
        }

        //使用abstract關鍵字宣告抽象屬性
        public abstract double Area
        {
            get;
        }
    }

    public class Circle : Shape
    {
        public Circle(double L) : base(L) { }
        public override double Area
        {
            get
            {
                return System.Math.PI * Line * Line;
            }
        }
    }

    public class Square : Shape
    {
        public Square(double L) : base(L) { }
        public override double Area
        {
            get
            {
                return Line * Line;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape obj1 = new Circle(10);
            Shape obj2 = new Square(10);
            Console.WriteLine("半徑為10之圓面積為" + obj1.Area.ToString());
            Console.WriteLine("邊長為10之正方形面積為" + obj2.Area.ToString());
            Console.ReadLine();
        }
    }
}
