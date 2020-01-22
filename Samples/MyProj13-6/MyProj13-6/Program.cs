using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_6
{
    public interface MyInterface1
    {
        void M1();
    }

    //宣告MyInterface2介面繼承自MyInterface1介面
    public interface MyInterface2 : MyInterface1
    {
        void M2();
    }

    //宣告MyClass類別要實作MyInterface2介面的所有成員
    public class MyClass : MyInterface2
    {
        public void M1()
        {
            Console.WriteLine("這是MyInterface2繼承自MyInterface1的M1()方法");
        }

        public void M2()
        {
            Console.WriteLine("這是MyInterface2自己宣告的M2()方法");
        }

        public void M3()
        {
            Console.WriteLine("這是MyClass類別自己宣告的M3()方法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.M1();
            obj.M2();
            obj.M3();
            Console.ReadLine();
        }
    }
}
