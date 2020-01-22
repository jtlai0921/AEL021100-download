using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_3
{
    public class BaseClass
    {
        public void M1() { Console.WriteLine("這是父類別的M1()方法"); }
    }

    public class SubClass : BaseClass
    {
        //使用new關鍵字遮蔽父類別的方法
        public new void M1() { Console.WriteLine("這是子類別的M1()方法"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();           //建立一個隸屬於BaseClass的物件
            SubClass obj2 = new SubClass();             //建立一個隸屬於SubClass的物件
            obj1.M1();                                  //呼叫BaseClass的M1() 方法
            obj2.M1();                                  //呼叫SubClass的M1() 方法
            Console.ReadLine();
        }
    }
}
