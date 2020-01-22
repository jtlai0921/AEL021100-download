using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_10
{
    class Demo
    {
        public static int Value;
        static Demo()                           //宣告靜態建構函式
        {
            Value = 100;                            //設定靜態成員的初始值
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("靜態變數Value的值為" + Demo.Value);
            Console.ReadLine();
        }
    }
}
