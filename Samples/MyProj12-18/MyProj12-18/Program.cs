using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_18
{
    public struct Complex                                                               //宣告Complex結構
    {
        private double a, b;

        public Complex(double d1, double d2)                                //結構的建構函式
        {
            a = d1;
            b = d2;
        }

        public static Complex operator +(Complex C1, Complex C2)    //重載 + 運算子
        {
            Complex C3 = new Complex((C1.a + C2.a), (C1.b + C2.b));
            return C3;
        }

        public override string ToString()                                       //覆蓋ToString() 方法
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
            Complex C1 = new Complex(1, 2);                                 //建立第一個結構案例
            Complex C2 = new Complex(5, -8);                                //建立第二個結構案例
            Complex C3 = C1 + C2;                                                   //建立第三個結構案例
            Console.WriteLine("第一個複數的值為" + C1.ToString());
            Console.WriteLine("第二個複數的值為" + C2.ToString());
            Console.WriteLine("第三個複數的值為" + C3.ToString());
            Console.ReadLine();
        }
    }
}
