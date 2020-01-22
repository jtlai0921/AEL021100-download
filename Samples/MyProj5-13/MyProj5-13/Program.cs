using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10));
            Console.WriteLine(Add(10, 5));
            Console.ReadLine();
        }

        private static int Add(int X)
        {
            return ++X;
        }

        private static int Add(int X, int Y)
        {
            return X + Y;
        }
    }
}
