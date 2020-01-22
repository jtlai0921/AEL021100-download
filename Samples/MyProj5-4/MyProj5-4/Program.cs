using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            Method1(ref X);
            Console.WriteLine("經過方法呼叫後的X值為" + X);
            Console.ReadLine();
        }

        private static void Method1(ref int A)
        {
            A = 1;
        }
    }
}
