using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_5
{
    public delegate void FunctionPointer();

    class Program
    {
        public static void M1()
        {
            Console.WriteLine("這是M1()方法");
        }

        public static void M2()
        {
            Console.WriteLine("這是M2()方法");
        }

        public static void M3()
        {
            Console.WriteLine("這是M3()方法");
        }

        static void Main(string[] args)
        {
            FunctionPointer FP;                     //宣告變數FP為委派型別
            FP = new FunctionPointer(M1);           //令FP指向M1() 方法
            FP += new FunctionPointer(M2);          //將指向M2() 方法的委派加入FP
            FP += new FunctionPointer(M3);          //將指向M3() 方法的委派加入FP
            FP();                                   //執行FP
            Console.WriteLine();
            FP -= new FunctionPointer(M2);          //從FP移除指向M2() 方法的委派
            FP();                                   //執行FP委派
            Console.ReadLine();
        }
    }
}
