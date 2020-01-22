using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_6
{
    public delegate double Operations(double Value);

    public class Mathematics
    {
        public static double Square(double Value)               //宣告委派所要呼叫的方法
        {
            return System.Math.Sqrt(Value);
        }

        public static double Absolute(double Value)             //宣告委派所要呼叫的方法
        {
            return System.Math.Abs(Value);
        }
    }

    class Program
    {
        public static void ProcessOperations(Operations Op, double Value)
        {
            Console.WriteLine("運算結果為" + Op(Value));
        }

        static void Main(string[] args)
        {
            Operations Op1 = new Operations(Mathematics.Square);        //建立委派物件
            Operations Op2 = new Operations(Mathematics.Absolute);      //建立委派物件
            ProcessOperations(Op1, 2);
            ProcessOperations(Op2, -100.5);
            Console.ReadLine();
        }
    }
}
