using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_13
{
    public class Class1                         //宣告外部類別Class1
    {
        public int i = 10;                      //在外部類別內宣告一個案例變數i
        public static int j = 20;               //在外部類別內宣告一個靜態變數j

        public void F11()                       //在外部類別內宣告一個案例方法
        { Console.WriteLine("呼叫外部類別的F11() 案例方法"); }

        public static void F12()                //在外部類別內宣告一個靜態方法
        { Console.WriteLine("呼叫外部類別的F12() 靜態方法"); }

        public class Class2                     //宣告內部類別Class2
        {
            public int x = 30;                  //在內部類別內宣告一個案例變數x
            public static int y = 40;           //在內部類別內宣告一個靜態變數y

            public void F21()                   //在內部類別內宣告一個案例方法
            { Console.WriteLine("呼叫內部類別的F21() 案例方法"); }

            public static void F22()            //在內部類別內宣告一個靜態方法
            { Console.WriteLine("呼叫內部類別的F22() 靜態方法"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
