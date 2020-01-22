using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_7
{
    public interface MyInterface1
    {
        void M1();
    }

    public interface MyInterface2
    {
        void M1();
    }

    public class MyClass : MyInterface1, MyInterface2
    {
        public void M1()
        {
            Console.WriteLine("這是MyInterface1的M1()方法");
        }

        void MyInterface2.M1()
        {
            Console.WriteLine("這是MyInterface2的M1()方法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.M1();
            ((MyInterface2)obj).M1();
            Console.ReadLine();
        }
    }
}
