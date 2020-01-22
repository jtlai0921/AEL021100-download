using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_1
{
    public struct Complex
    {
        private double a, b;
        public Complex(double d1, double d2)
        {
            a = d1;
            b = d2;
        }

        public static Complex operator +(Complex C1, Complex C2)
        {
            Complex C3 = new Complex((C1.a + C2.a), (C1.b + C2.b));
            return C3;
        }

        public override string ToString()
        {
            string Str = "";
            if (b >= 0) Str = a + " + " + b + "i";
            else Str = a + " - " + (-b) + "i";
            return Str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex(1, 2);             //以new關鍵字建立第一個結構案例
            Complex C2 = new Complex(5, -8);            //以new關鍵字建立第二個結構案例
            Complex C3 = C1 + C2;                       //建立第三個結構案例，+ 已經被重載
            Console.WriteLine("第一個複數的值為" + C1.ToString());
            Console.WriteLine("第二個複數的值為" + C2.ToString());
            Console.WriteLine("第三個複數的值為" + C3.ToString());
            Console.ReadLine();
        }
    }
}
